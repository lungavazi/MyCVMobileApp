using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Profile.Models;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Profile.ViewModel
{
    public class AddWorkHistoryViewModel: BaseViewModel
    {
        public ICommand SaveWorkCommand { get; set; }
        WorkHistory work;

        private string _companyName;
        private string _position;
        private string _workDescription;
        private bool _isCurrentJob;
        private DateTime _fromDate = DateTime.Now.Date;
        private DateTime _toDate = DateTime.Now.Date;
        private DateTime _maximumDate = DateTime.Now.Date;
        private string _achievements;

        public AddWorkHistoryViewModel()
        {
            SaveWorkCommand = new Command(async () => await SaveWork());
        }

        async Task SaveWork()
        {
            work = new WorkHistory();
            work.CompanyName = CompanyName;
            work.Position = Position;
            work.WorkDescription = WorkDescription;
            work.FromDate = FromDate;
            work.ToDate = ToDate;
            work.IsCurrentJob = IsCurrentJob;
            work.Achievements = Achievements;
            work.UserName = GlobalUserName;

            if (ValidateSaveWork(work))
            {
                SaveWorkHistory(work);
                await Application.Current.MainPage.Navigation.PopAsync();
            }
        }

        Boolean ValidateSaveWork(WorkHistory work)
        {
            if (string.IsNullOrWhiteSpace(work.CompanyName))
            {
                Application.Current.MainPage.DisplayAlert("", "Employer name is required", "OK");
                return false;
            }

            if (string.IsNullOrWhiteSpace(work.Position))
            {
                Application.Current.MainPage.DisplayAlert("", "Position held is required", "OK");
                return false;
            }

            if (string.IsNullOrWhiteSpace(work.WorkDescription))
            {
                Application.Current.MainPage.DisplayAlert("", "Work description is required", "OK");
                return false;
            }

            if (FromDate > ToDate)
            {
                Application.Current.MainPage.DisplayAlert("", "From date can not be after to date", "OK");
                return false;
            }

            if (ToDate < FromDate)
            {
                Application.Current.MainPage.DisplayAlert("", "To date can not be before from date", "OK");
                return false;
            }
            return true;
        }

        public string CompanyName
        {
            get => _companyName;
            set => _companyName = value;
        }

        public string Position
        {
            get => _position; 
            set => _position = value;
        }

        public string WorkDescription
        {
            get => _workDescription; 
            set => _workDescription = value;
        }

        public Boolean IsCurrentJob
        {
            get => _isCurrentJob;
            set => _isCurrentJob = value;
        }

        public DateTime FromDate
        {
            get => _fromDate;
            set => _fromDate = value; 
        }

        public DateTime ToDate
        {
            get => _toDate;
            set => _toDate = value;
        }

        public string Achievements
        {
            get => _achievements;
            set => _achievements = value;
        }

        public DateTime MaximumDate
        {
            get => _maximumDate;
            set => _maximumDate = value;
        }
    }
}
