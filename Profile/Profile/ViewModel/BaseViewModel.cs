using Profile.Data;
using Profile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using Xamarin.Forms;

namespace Profile.ViewModel
{


    public class BaseViewModel: INotifyPropertyChanged
    {
        DataBase db = new DataBase();
        public static string GlobalFullName;
        public static string GlobalUserName;
        public static Boolean GlobalEnterPasswordLogin = true;
        public static Boolean GlobalShowIDNumber = true;
        public static ImageSource GlobalUserImage;

        public BaseViewModel()
        {
            //AboutMe profile = GetProfile(BaseUserName);
        }
        public string BaseUserName { get; set; }
        public string BaseFullName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public async void AlertMessage(string alertMsg)
        {
            await Application.Current.MainPage.DisplayAlert("", alertMsg, "OK");
        }
        public void SaveProfile(AboutMe profile)
        {
            db.SaveProfile(profile);
            GlobalUserName = profile.UserName;
            if (string.IsNullOrWhiteSpace(profile.Password) == false)
            {
                User user = new User { Password = profile.Password, UserName = profile.UserName };
                db.SaveUser(user);
            }
        }

        public void SaveAcademic(Education education)
        {
            db.SaveEducation(education);
        }

        public void SaveWorkHistory(WorkHistory work)
        {
            db.SaveWorkHistory(work);
        }

        public List<Education> GetAcademicList(string userName)
        {
            return db.GetAcademicList(userName);
        }

        public AboutMe GetProfile(string userName)
        {
            return db.GetProfile(userName);
        }

        public List<WorkHistory> GetWorkHistoryList(string userName)
        {
            return db.GetWorkHistoryList(userName);
        }

        public int DeleteEducation(Education education)
        {
            return db.DeleteEducation(education);
        }

        public Boolean ValidateSaveProfile(AboutMe profile)
        {
            if (string.IsNullOrWhiteSpace(profile.Title))
            {
                AlertMessage("Title is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(profile.Name))
            {
                AlertMessage("Name is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(profile.Surname))
            {
                AlertMessage("Surname is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(profile.Email))
            {
                AlertMessage("Email is required.");
                return false;
            }
            else if (!ValidateEmail(profile.Email))
            {
                AlertMessage("Enter valid email address");
                return false;
            }
            else if(ProfileExists(profile.Email))
            {
                AlertMessage($"Account already exists with email {profile.Email} .");
                return false;
            }
            if (GetUserData(profile.UserName, string.Empty) != null && profile.ID == 0)
            {
                AlertMessage($"Account already exists with user name {profile.UserName} .");
                return false;
            }
            if (string.IsNullOrWhiteSpace(profile.Telephone))
            {
                AlertMessage("Telephone is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(profile.Gender))
            {
                AlertMessage("Gender is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(profile.Address))
            {
                AlertMessage("Address is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(profile.Nationality))
            {
                AlertMessage("Nationality is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(profile.IDNumber) && GlobalShowIDNumber)
            {
                AlertMessage("Id number is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(profile.UserName) == true || string.IsNullOrWhiteSpace(profile.Password) == true)
            {
                AlertMessage("Login information is required.");
                return false;
            }
            else if (profile.Password != profile.ConfirmPassword)
            {
                AlertMessage("Password combination does not match.");
                return false;
            }

            return true;
        }

        public User GetUserData(string username, string password)
        {
            return db.GetUserData(username, password);
        }

        private bool ProfileExists(string email)
        {
            return db.GetProfileByEmail(email)?.ID > 0;
        }

        public Boolean ValidateSaveWork(WorkHistory work)
        {
            if (string.IsNullOrWhiteSpace(work.Position))
            {
                AlertMessage("Position is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(work.CompanyName))
            {
                AlertMessage("Company Name is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(work.WorkDescription))
            {
                AlertMessage("Work Description is required.");
                return false;
            }
            if (work.FromDate > work.ToDate)
            {
                AlertMessage("From date can not be after to date");
                return false;
            }
            if (work.ToDate < work.FromDate)
            {
                AlertMessage("To date can not be before from date");
                return false;
            }
            return true;
        }

        public Boolean ValidateSaveEducation(Education education, bool TestingMode = false)
        {
            if (string.IsNullOrWhiteSpace(education.QualilificationName))
            {
                if (TestingMode == false) AlertMessage("Qualification Name is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(education.QualificationLevel))
            {
                if (TestingMode == false) AlertMessage("Qualification Level is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(education.InstitutionName))
            {
                if (TestingMode == false) AlertMessage("Institution Name is required.");
                return false;
            }
            if (education.FromDate > education.ToDate)
            {
                if (TestingMode == false) AlertMessage("From date can not be after to date");
                return false;
            }
            if (education.ToDate < education.FromDate)
            {
                if (TestingMode == false) AlertMessage("To date can not be before from date");
                return false;
            }
            return true;
        }

        public bool ValidateEmail(string email)
        {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                return match.Success;           
        }
    }
}
