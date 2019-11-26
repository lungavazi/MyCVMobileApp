using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Profile.ViewModel;

namespace Profile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DocumentView : ContentPage
	{
		public DocumentView ()
		{
			InitializeComponent ();
            BindingContext = new DocumentViewModel();
        }
	}
}