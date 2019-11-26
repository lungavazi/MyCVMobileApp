using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Profile.ViewModel;

namespace Profile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddWorkView : ContentPage
	{
		public AddWorkView ()
		{
			InitializeComponent ();
            BindingContext = new AddWorkHistoryViewModel();
		}
	}
}