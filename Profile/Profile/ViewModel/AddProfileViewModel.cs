using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Profile.Models;
using Profile.Data;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Profile.ViewModel
{
    public class AddProfileViewModel: BaseViewModel
    {
        AboutMe profile;
        private string _name;
        private string _surname;
        private string _title;
        private Boolean _isProfileActive = true;
        private Image _image;
        private string _idNumber;
        private string _nationality;
        private string _address;
        private string _gender;
        private string _telephone;
        private string _email;

        public ICommand SaveProfileCommand { get; set; }

        public AddProfileViewModel()
        {
            SaveProfileCommand = new Command(async () => await SaveProfile());
        }

        async Task SaveProfile()
        {
            profile = new AboutMe();
            profile.Title = Title;
            profile.UserName = "Lunga.Vazi";
            profile.Name = Name;
            profile.Surname = Surname;
            profile.FullName = $"{Name} {Surname}";
            profile.FullName = Name + " " + Surname;
            profile.IDNumber = IDNumber;
            profile.Telephone = Telephone;
            profile.Gender = Gender;
            profile.Address = Address;
            profile.Nationality = Nationality;
            //profile.Image = Image;
            profile.Email = Email;
            profile.IsProfileActive = IsProfileActive;

            if (ValidateSaveProfile(profile))
            {
                SaveProfile(profile);
                await Application.Current.MainPage.Navigation.PopAsync();
            }
        }        

        public string Title
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
            set => _telephone = value;
        }
        public string Email
        {
            get => _email;
            set => _email = value;
        }
        public string Gender
        {
            get => _gender;
            set => _gender = value;
        }
        public string Address
        {
            get => _address;
            set => _address = value;
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
        public Image Image
        {
            get => _image;
            set => _image = value;
        }
        Boolean IsProfileActive
        {
            get => _isProfileActive;
            set => _isProfileActive = value;
        }
    }
}
