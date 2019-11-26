using System;
using System.Collections.ObjectModel;
using Profile.Models;
using Xamarin.Forms;
using System.Windows.Input;
using Profile.Views;
using Profile.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Profile.ViewModel
{
    public class AboutMeViewModel : BaseViewModel
    {
        public ObservableCollection<AboutMe> Profile { get; set; }
        public ICommand AddProFileCommand { get; set; }
        public Boolean AddButtonVisible { get; set; }
        private AboutMe _profile;
        public Boolean IsProfileEmpty { get; set; }
        public AboutMeViewModel()
        {
            AddProFileCommand = new Command(AddProfile);
            var profileinfo = GetProfile(GlobalUserName);
            Profile = new ObservableCollection<AboutMe>();
            Profile.Add(profileinfo);

            if (Profile != null)
            {
                GlobalFullName = $"{profileinfo.Name} {profileinfo.Surname}";
                GlobalUserImage = "lunga.png";
                IsProfileEmpty = false;
            }
            else
            {
                IsProfileEmpty = true;
                AddButtonVisible = true;
            }
        }

        public AboutMe SelectedItem
        {
            get => _profile;
            set
            {
                if (value != null)
                {
                    _profile = value;
                    EditProfile();
                }
            }
        }
        private void AddProfile()
        {
            Application.Current.MainPage.Navigation.PushAsync(new AddProfileView());
        }
        private void EditProfile()
        {
            Application.Current.MainPage.Navigation.PushAsync(new EditProfileView());
        }

    }
}
