using System;
using System.Collections.Generic;
using System.Text;

namespace Profile.ViewModel
{
    public class SettingsViewModel: BaseViewModel
    {
        
        public SettingsViewModel()
        {

        }

        public Boolean EnterPasswordLogin
        {
            get => GlobalEnterPasswordLogin; 
            set
            {
                if (GlobalEnterPasswordLogin |= value)
                {
                    //OnPropertyChanged(nameof(EnterPasswordLogin));
                    GlobalEnterPasswordLogin = value;
                }
            }
        }

        public Boolean ShowIDNumber
        {
            get { return GlobalShowIDNumber; }
            set
            {
                if (GlobalShowIDNumber |= value)
                {
                    //OnPropertyChanged(nameof(ShowIDNumber));
                    GlobalShowIDNumber = value;
                }
            }
        }
    }
}


