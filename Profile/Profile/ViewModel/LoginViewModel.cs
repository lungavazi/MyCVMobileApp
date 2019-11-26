using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Profile.Views;
using System.Windows.Input;

namespace Profile.ViewModel
{
    public class LoginViewModel: BaseViewModel
    {
        private string _userName;
        private string _passWord;
        public ICommand SignInCommand { get; set; }
        public ICommand SignUpCommand { get; set; }
        public ICommand ResetPasswordCommand { get; set; }        

        public LoginViewModel()
        {
            SignInCommand = new Command(ValidateUserLogin);
            SignUpCommand = new Command(NavigateToRegisterView);
            ResetPasswordCommand = new Command(NavigateToResetPasswordView);
        }

        private void NavigateToResetPasswordView()
        {
            Application.Current.MainPage.Navigation.PushAsync(new ResetPasswordView());
        }

        private void ValidateUserLogin()
        {
            if (ValidateUser())
            {
                Application.Current.MainPage = new NavigationPage(new MasterPage());
            }
        }

        private void NavigateToRegisterView()
        {
            Application.Current.MainPage.Navigation.PushAsync(new RegisterView());
        }
        private bool ValidateUser()
        {
            if (string.IsNullOrWhiteSpace(UserName))
            {
                AlertMessage("User name is required");
                return false;
            }
            if (string.IsNullOrWhiteSpace(Password))
            {
                AlertMessage("Password is required");
                return false;
            }
            //*** validate if user exist
            var userinfor = GetUserData(UserName, Password);
            if (userinfor != null)
            {
                GlobalUserName = userinfor.UserName;
                return true;
            }
            else
            {
                AlertMessage("Invalid user and/or password entered");
                return false;
            }
        }

        public string UserName
        {
            get => _userName;
            set => _userName = value;
        }

        public string Password
        {
            get => _passWord;
            set => _passWord = value;
        }
    }
}
