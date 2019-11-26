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
	public partial class WorkHistoryView : ContentPage
	{
		public WorkHistoryView ()
		{
			InitializeComponent ();
            BindingContext = new WorkHistoryViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            //new WorkHistoryView();
        }
    }
}