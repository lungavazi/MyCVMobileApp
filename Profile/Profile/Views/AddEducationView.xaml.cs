using Profile.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Profile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddEducationView : ContentPage
	{
		public AddEducationView ()
		{
			InitializeComponent ();
            BindingContext = new AddEducationViewModel();
        }
	}
}