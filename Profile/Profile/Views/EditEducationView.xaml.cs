using Profile.Models;
using Profile.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Profile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EditEducationView : ContentPage
	{
        public EditEducationView(Education education)
        {
            InitializeComponent();
            BindingContext = new EditEducationViewModel(education);
        }
	}
}