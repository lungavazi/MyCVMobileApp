using Profile.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using Profile.Views;
using System.Windows.Input;

namespace Profile.ViewModel
{

    public class EducationViewModel : BaseViewModel
    {
        public ICommand RefreshCommand { get; set; }
        public ObservableCollection<Education> EducationList{get;set;}          
        public ICommand AddEducationCommand { get; set; }
        public ICommand DeleteIconCommand { get; set; }
        public Boolean IsEducationEmpty { get; set; }

        //global user name
        public Boolean _isBusy = false;
        private Education _education;

        public EducationViewModel()
        {
            AddEducationCommand = new Command(AddEducation);

            EducationList = new ObservableCollection<Education>(GetAcademicList(GlobalUserName));
            if (EducationList == null)
            {
                IsEducationEmpty = true;
            }
            else { IsEducationEmpty = false; }
            DeleteIconCommand = new Command(DeleteEducation);
        }

        void DeleteEducation(object s)
        {
            AlertMessage($"Parameter {s}");
        }
        
        public Education SelectedItem
        {
            get => _education; 
            set {
                if (value != null)
                {
                    _education = value;
                    EditEducation();
                }
            }
        }

        public Boolean IsBusy
        {
            get => _isBusy; 
            set => _isBusy = value; 
        }

        private void AddEducation()
        {
            Application.Current.MainPage.Navigation.PushAsync(new AddEducationView());
        }

        public void EditEducation()
        {
            Education education = SelectedItem;
            Application.Current.MainPage.Navigation.PushAsync(new EditEducationView(education));
        }
    }
}
