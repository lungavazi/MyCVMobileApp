using System;
using Xamarin.Forms;

namespace Profile.ViewModel
{
    public class ItemSelectedBehavior: Behavior<ListView>
    {

        protected override void OnAttachedTo(ListView bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.ItemSelected += BindableOnItemSeleced;
        }

        private void BindableOnItemSeleced(object sender, SelectedItemChangedEventArgs e)
        {
            var lstView = sender as ListView;
            lstView.SelectedItem = null;
        }

        protected override void OnDetachingFrom(ListView bindable)
        {
            base.OnDetachingFrom(bindable); 
            bindable.ItemSelected -= BindableOnItemSeleced;
        }
    }
}
