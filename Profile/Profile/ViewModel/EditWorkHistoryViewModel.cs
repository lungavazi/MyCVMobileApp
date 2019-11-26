using Profile.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Profile.ViewModel
{
    class EditWorkHistoryViewModel: BaseViewModel
    {
        //globl user name 
        WorkHistory work;
        public ICommand EditWorkCommand { get; set;}
        private string _workDescription;
        private int _id;
        private string _position;
        private string _achievements;
        private string _companyName;
        private DateTime _fromDate;
        private DateTime _toDate;

        public EditWorkHistoryViewModel(WorkHistory work)
        {
            EditWorkCommand = new Command(Save);
            _id = work.ID;
            _position = work.Position;
            _companyName = work.CompanyName;
            _workDescription = work.WorkDescription;
            _fromDate = work.FromDate;
            _toDate = work.ToDate;
        }

        private void Save()
        {
            work = new WorkHistory();
            work.ID = ID;
            work.UserName = GlobalUserName;
            work.Position = Position;
            work.CompanyName = CompanyName;
            work.WorkDescription = WorkDescription;
            work.Achievements = Achievements;
            work.FromDate = FromDate;
            work.ToDate = ToDate;

            if (ValidateSaveWork(work))
            {
                SaveWorkHistory(work);
                Application.Current.MainPage.Navigation.PopAsync();
            }
        }

        public int ID
        {
            get => _id;
        }
        public string Position
        {
            get => _position; 
            set => _position = value;
        }
        public string CompanyName
        {
            get => _companyName; 
            set => _companyName = value;
        }
        public string WorkDescription
        {
            get => _workDescription; 
            set => _workDescription = value; 
        }
        public string Achievements
        {
            get => _achievements; 
            set => _achievements = value;
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

    }
}
