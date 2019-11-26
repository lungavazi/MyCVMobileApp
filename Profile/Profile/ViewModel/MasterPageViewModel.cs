using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Profile.Models;
using Profile.Views;
using Xamarin.Forms;

namespace Profile.ViewModel
{
    public class MasterPageViewModel:BaseViewModel
    {
        public ObservableCollection<MasterPageModel> MasterPageList { get; set; }
        public ICommand LogoutCommand { get; set; }
        public ICommand ImageCommand { get; set; }
        private string _title = "MyProfile";
        public MasterPageViewModel()
        {
            MasterPageList = new ObservableCollection<MasterPageModel>();
            MasterPageList.Add(new MasterPageModel() { Title = "Documents", Icon = "documents.png", Type = "Documents" });
            MasterPageList.Add(new MasterPageModel() { Title = "Settings", Icon = "settings.png", Type = "Settings" });
            MasterPageList.Add(new MasterPageModel() { Title = "About App", Icon = "aboutApp.png", Type = "AboutApp" });

            ImageCommand = new Command(PhotoAction);
            LogoutCommand = new Command(LogoutUser);

        }

        private async void PhotoAction()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                AlertMessage("Device does not support pick photo");
                return;
            }

            try
            {
                _file = await CrossMedia.Current.PickPhotoAsync();

                GlobalUserImage = ImageSource.FromStream(() =>
                   { return _file.GetStream(); }); 
            }
            catch (Exception ex)
            {
                AlertMessage(ex.Message);
            }

            if (_file == null)
            {
                return;
            }
        }

        private async void LogoutUser()
        {
            bool answer = await Application.Current.MainPage.DisplayAlert("", "Are you sure you would like to sign out?", "Yes", "No");
            if (answer)
            {
                //logout user 
                 Application.Current.MainPage = new NavigationPage(new LoginView());
            }
        }

        private MasterPageModel _masterPageModel;
        private MediaFile _file;

        public MasterPageModel SelectedDetailPage
        {
            get => _masterPageModel;
            set
            {
                if (_masterPageModel != value)
                {
                    _masterPageModel = value;
                    ShowMasterDetailPage(_masterPageModel.Type);
                }
            }
        }    

        public string Title
        {
            get => _title; 
            set => _title = value;
        }

         public ImageSource UserImage
        {
            get => GlobalUserImage;
            set => GlobalUserImage = value;
        }
        public string FullName { get { return GlobalFullName; }}

        private void ShowMasterDetailPage(string viewType)
        {
            switch (viewType)
            {
                case "Settings":
                    Application.Current.MainPage.Navigation.PushAsync(new SettingsView());
                    break;
                case "Documents":
                    Application.Current.MainPage.Navigation.PushAsync(new DocumentView());
                    break;
                case "AboutApp":
                    Application.Current.MainPage.Navigation.PushAsync(new AboutAppView());
                    break;
                default:
                    break;
            }
        }        
    }
}
