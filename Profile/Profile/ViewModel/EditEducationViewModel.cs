using Profile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Profile.ViewModel
{
    public class EditEducationViewModel : BaseViewModel
    {
        Education education;
        private string _qualificationName;
        private string _institutionName;
        private string _qualificationLevel;
        private DateTime _fromDate;
        private DateTime _toDate;
        string UserName = "Lunga.Vazi";
        private int _id;
        public ICommand EditEducationCommand { get; set; }

        public EditEducationViewModel(Education education)
        {
            _id = education.ID;
            _qualificationName = education.QualilificationName;
            _institutionName = education.InstitutionName;
            _qualificationLevel = education.QualificationLevel;
            _fromDate = education.FromDate;
            _toDate = education.ToDate;
            _qualificationName = education.QualilificationName;
            _qualificationName = education.QualilificationName;
            EditEducationCommand = new Command(Save);

        }

        private void Save()
        {
            education = new Education();
            education.ID = ID;
            education.UserName = UserName;
            education.QualificationLevel = QualificationLevel;
            education.QualilificationName = QualilificationName;
            education.InstitutionName = InstitutionName;
            education.FromDate = FromDate;
            education.ToDate = ToDate;

            if (ValidateSaveEducation(education))
            {
                SaveAcademic(education);
                Application.Current.MainPage.Navigation.PopAsync();
            }
        }

        public int ID
        {
            get => _id;
            set => _id = value;
        }
        public string QualilificationName
        {
            get => _qualificationName;
            set => _qualificationName = value;
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
    }
}
