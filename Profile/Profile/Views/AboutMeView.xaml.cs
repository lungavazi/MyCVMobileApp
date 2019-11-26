using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Profile.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Profile.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AboutMeView : ContentPage
	{
		public AboutMeView ()
		{
			InitializeComponent ();
            BindingContext = new AboutMeViewModel();
        }

        //    protected override void OnAppearing()
        //    {
        //        base.OnAppearing();
        //        new AboutMeView();
        //    }
    }
}