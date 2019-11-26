using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Profile.Data;
using Profile.Models;
using System.IO;
using System.Windows.Input;

namespace Profile.ViewModel
{
    public class AddEducationViewModel: BaseViewModel
    {
        Education education;
        public ICommand SaveEducationCommand { get; set; }

        public AddEducationViewModel()
        {
            SaveEducationCommand = new Command(async ()=> await AddEducation());
        }

        private string _qualilificationName;
        private string _institutionName;
        private string _qualificationLevel;
        private DateTime _fromDate = DateTime.Now;
        private DateTime _toDate = DateTime.Now;
        private DateTime _maximumDate = DateTime.Now;
        //Global variable
        //bool isBusy;

        async Task AddEducation()
        {
            //IsBusy = true;
            education = new Education();
            education.QualilificationName = QualilificationName;
            education.InstitutionName = InstitutionName;
            education.QualificationLevel = QualificationLevel;
            education.FromDate = FromDate;
            education.ToDate = ToDate;
            education.Status = "Complete";
            education.UserName = GlobalUserName;

            if (ValidateAddEducation(education))
            {
                SaveAcademic(education);
                await Application.Current.MainPage.Navigation.PopAsync();
            }

        }
        Boolean  ValidateAddEducation(Education education) 
        {
            if (string.IsNullOrWhiteSpace(education.QualilificationName) == true)
            {
                AlertMessage("Qualification Name is a required field");
                return false;
            }                 
            if (string.IsNullOrWhiteSpace(education.InstitutionName) == true)
            {
                AlertMessage("InstitutionName is a required field");
                return false;
            }
            if (string.IsNullOrWhiteSpace(education.QualificationLevel) == true)
            {
                AlertMessage("Qualification Level is a required field");
                return false;
            }
            if (education.FromDate > DateTime.Now)
            {
                AlertMessage("From date can not be after to date");
                return false;
            }
            if (education.ToDate < education.FromDate)
            {
                AlertMessage("To date can not be before to date");
                return false;
            }
            return true;
        }

        public string QualilificationName
        {
            get => _qualilificationName;
            set => _qualilificationName = value; 
        }
        public string InstitutionName
        {
            get => _institutionName; 
            set => _institutionName = value; 
        }
        public string QualificationLevel
        {
            get => _qualificationLevel; 
            set => _qualificationLevel = value; 
        }
        public DateTime FromDate
        {
            get => _fromDate; 
            set => _fromDate = value; 
        }
        public DateTime ToDate
        {
            get => _toDate; 
            set => _toDate = value; 
        }

        public DateTime MaximumDate
        {
            get => _maximumDate; 
            set => _maximumDate = value;
        }
        //public Boolean IsBusy
        //{
        //    get { return isBusy; }
        //    set { isBusy = value; }
        //}
    }
}
