using System;
using System.Windows.Input;
using Profile.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Profile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ResetPasswordView : ContentPage
	{
        public ICommand SubmitCommand = new Command(ResetPassword);

        private static void ResetPassword(object obj)
        {
            throw new NotImplementedException();
        }

        public ResetPasswordView ()
		{
            InitializeComponent();
            BindingContext = new ResetPasswordViewModel();
		}
	}
}