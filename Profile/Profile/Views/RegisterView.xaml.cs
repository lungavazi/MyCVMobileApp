using Profile.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Profile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RegisterView : ContentPage
	{
		public RegisterView ()
		{
			InitializeComponent ();
            BindingContext = new RegisterViewModel();
		}
	}
}