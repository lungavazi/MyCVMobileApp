using Profile.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Profile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EducationView : ContentPage
	{
		public EducationView ()
		{
			InitializeComponent ();
            BindingContext = new EducationViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            new EducationViewModel();
        }
    }
}