using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Profile.Models;
using Xamarin.Forms;
using Profile.Views;
using System.Windows.Input;

namespace Profile.ViewModel
{

    public class WorkHistoryViewModel: BaseViewModel
    {
        public ObservableCollection<WorkHistory> WorkHistoryList { get; set; }
        public ICommand AddWorkCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public Boolean IsWorkEmpty { get; set; }
        public WorkHistoryViewModel()
        {
            AddWorkCommand = new Command(AddWork);
            DeleteCommand = new Command(DeleteWork);
            WorkHistoryList = new ObservableCollection<WorkHistory>(GetWorkHistoryList(GlobalUserName));
            if (WorkHistoryList == null)
            {
                IsWorkEmpty = true;
            }
            else { IsWorkEmpty = false; }
        }

        private void DeleteWork()
        {
            var s = "Lunga";
        }

        private WorkHistory _workHistory;

        public WorkHistory SelectedItem
        {
            get => _workHistory;
            set
            {
                if (value != null)
                {
                    _workHistory = value;
                    EditWork();
                }
            }
        }

        private void EditWork()
        {
            Application.Current.MainPage.Navigation.PushAsync(new EditWorkHistoryView(SelectedItem));
        }

        private void AddWork()
        {
            Application.Current.MainPage.Navigation.PushAsync(new AddWorkView());
        }
    }
}
