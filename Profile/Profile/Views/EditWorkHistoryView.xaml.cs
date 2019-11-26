using Profile.Models;
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
	public partial class EditWorkHistoryView : ContentPage
	{
		public EditWorkHistoryView (WorkHistory work)
		{
			InitializeComponent ();
            BindingContext = new EditWorkHistoryViewModel(work);
		}
	}
}