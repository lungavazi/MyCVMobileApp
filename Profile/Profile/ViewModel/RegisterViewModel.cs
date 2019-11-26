using Profile.Models;
using Profile.Views;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Profile.ViewModel
{
    public class RegisterViewModel : BaseViewModel
    {
        private string _title;
        private string _name;
        private string _gender;
        private string _nationality;
        private string _idNumber;
        private string _address;
        private string _email;
        private string _telephone;
        private string _surname;
        private string _userName;
        private string _password;
        private string _confirmpassword;
        //int Encrypt = 1;
        //int Decrypt = 2;

        //private Aes myAes = Aes.Create();
        public ICommand RegisterCommand { get; set; }
        private AboutMe aboutMe { get; set; }

        public RegisterViewModel()
        {
            RegisterCommand = new Command(RegisterProfile);
        }

        public enum EncryptionMode
        {
            Encrypt = 1,
            Decrypt = 2
        }

        private void RegisterProfile()
        {
            AboutMe profile = SetProfileProperties();
            if (ValidateSaveProfile(profile))
            {
                SaveProfile(profile);
                Application.Current.MainPage = new NavigationPage(new MasterPage());
            }
            //AlertMessage($"Plain Password {_password} Encrypted Password {DecryptPassword("gi5M3MBMBOVkgF3AhlJYfg==")}");
        }

        private AboutMe SetProfileProperties()
        {
            AboutMe _profile = new AboutMe {Name = Name, Surname = Surname, UserName = UserName , Title = Title, Email = Email, IsProfileActive = true,               
                 Address = Address, IDNumber = IDNumber, Password = Password, Gender = Gender,Telephone = Telephone, Nationality = Nationality, ConfirmPassword = ConfirmPassword};
            return _profile;
        }

        public string EncryptDecryptPassword(string password, EncryptionMode encryptionMode)
        {
            string storedKey = "KEY#*__c";
            string storedIV = "OKUikY_@";

            var random = new Random();
            byte[] key = new byte[8]; //Encryption Key 
            key = Encoding.UTF8.GetBytes(storedKey);
            byte[] IV = new byte[8];
            IV = Encoding.UTF8.GetBytes(storedIV);
            byte[] inputByteArray = new byte[8];

            try
            {  
                DESCryptoServiceProvider ObjDES = new DESCryptoServiceProvider();
                //inputByteArray = Encoding.UTF8.GetBytes(storedKey);
                inputByteArray = Convert.FromBase64String("i5M3MBMBOVkgF3AhlJYfg ==");
                MemoryStream Objmst = new MemoryStream();
                CryptoStream Objcs;

                if (encryptionMode == EncryptionMode.Encrypt)
                {
                    Objcs = new CryptoStream(Objmst, ObjDES.CreateEncryptor(key, IV), CryptoStreamMode.Write);
                }
                else
                {
                    Objcs = new CryptoStream(Objmst, ObjDES.CreateDecryptor(key, IV), CryptoStreamMode.Read);
                }
                Objcs.Write(inputByteArray, 0, 8);
                Objcs.FlushFinalBlock();

                return Convert.ToBase64String(Objmst.ToArray()); 
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string DecryptPassword(string cryptedString)
        {
            string storedKey = "KEY#*__c";
            string storedIV = "OKUikY_@";
            byte[] inputByteArray;
            byte[] key ; //Encryption Key 
            key = Encoding.UTF8.GetBytes(storedKey);
            byte[] IV ;
            IV = Encoding.UTF8.GetBytes(storedIV);
            inputByteArray = Convert.FromBase64String(cryptedString);
            if (String.IsNullOrEmpty(cryptedString))
            {
                throw new ArgumentNullException
                   ("The string which needs to be decrypted can not be null.");
            }
            DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
            //MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(cryptedString));
            MemoryStream memoryStream = new MemoryStream();
                    
            CryptoStream cryptoStream = new CryptoStream(memoryStream,cryptoProvider.CreateDecryptor(key, IV), CryptoStreamMode.Write);

            cryptoStream.Write(inputByteArray, 0, inputByteArray.Length);
            cryptoStream.FlushFinalBlock();

            Encoding encoding = Encoding.UTF8;

            return encoding.GetString(memoryStream.ToArray());
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
            set => _telephone = value;
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

        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }
        public string ConfirmPassword
        {
            get => _password;
            set => _password = value;
        }

    }
}
