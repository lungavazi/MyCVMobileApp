using Profile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Profile.Data;
using System.Windows.Input;

namespace Profile.ViewModel
{
    public class EditProfileViewModel: BaseViewModel
    {
        AboutMe Profile;
        public ICommand SaveProfileCommand { get; set; }
        private int _id;
        private string _userName;
        private string _title;
        private string _name;
        private string _surname;
        private string _telephone;
        private string _email;
        private string _address;
        private string _gender;
        private string _nationality;
        private string _idNumber;
        //string userName = "Lunga.Vazi";

        public EditProfileViewModel()
        {
            var Profile = new AboutMe();
             Profile = GetProfile(GlobalUserName);
              _title = Profile.Title;
              _name = Profile.Name;
              _surname = Profile.Surname;
              _idNumber = Profile.IDNumber;
              _telephone = Profile.Telephone;
              _address = Profile.Address;
              _nationality = Profile.Nationality;
              _email = Profile.Email;
              _gender = Profile.Gender;
              _id = Profile.ID;
              _userName = Profile.UserName;

              SaveProfileCommand = new Command(EditProfile);
        }

        private void EditProfile()
        {
            Profile = new AboutMe();
            Profile.Title = Title;
            Profile.Name = Name;
            Profile.Surname = Surname;
            Profile.Telephone = Telephone;
            Profile.Email = Email;
            Profile.IDNumber = IDNumber;
            Profile.Gender = Gender;
            Profile.Nationality = Nationality;
            Profile.Address = Address;
            Profile.ID = ID;

            if (ValidateSaveProfile(Profile))
            {
                SaveProfile(Profile);
                Application.Current.MainPage.Navigation.PopAsync();
            }
        }

        public int ID
        {
            get { return _id; }
        }
        public String Title
        {
            get => _title; 
            set => _title = value;
        }
        public string Name
        {
            get => _name; 
            set => _name = value;
        }
        public string Surname
        {
            get => _surname; 
            set => _surname = value;
        }
        public string Telephone
        {
            get => _telephone; 
            set =>_telephone = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value; 
        }
        public string Address
        {
            get => _address;
            set => _address = value;
        }
        public string Gender
        {
            get => _gender; 
            set => _gender = value;
        }
        public string Nationality
        {
            get => _nationality; 
            set => _nationality = value;
        }
        public string IDNumber
        {
            get => _idNumber; 
            set => _idNumber = value;
        }
    }
}
