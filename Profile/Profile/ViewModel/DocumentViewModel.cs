using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Plugin.FilePicker;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Profile.ViewModel
{
    public class DocumentViewModel:INotifyPropertyChanged
    {
        private string _fileName;

        public ICommand AddFileCommand { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public DocumentViewModel()
        {
            AddFileCommand = new Command(FileUpload);
        }

        private async void FileUpload()
        {
            var filedata = await CrossFilePicker.Current.PickFile();
            if (filedata == null)
                return;
            else { LabelFileName = filedata.FileName; }
        }

        public string LabelFileName
        {
            get => _fileName;
            set => _fileName = value;
        }
    }
}
