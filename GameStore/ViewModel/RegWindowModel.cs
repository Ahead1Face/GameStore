using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GameStore.Commands;
using GameStore.Vews;

namespace GameStore.ViewModel
{
    internal class RegWindowModel : INotifyPropertyChanged
    {
        private Command changeToMainWindow;
        public event EventHandler EventCloseWindow;
        public event PropertyChangedEventHandler PropertyChanged;

        string newUserLogin;
        string newUserEmail;

        public string NewUserLogin
        {
            get { return newUserLogin; }
            set
            {
                newUserLogin = value;
                //OnPropertyChanged("NewUserLogin");
            }
        }

        public string NewUserEmail
        {
            get { return newUserEmail; }
            set
            {
                newUserEmail = value;
                //OnPropertyChanged("NewUserEmail");
            }
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public Command ChangeToMainWindow
        {
            get
            {
                return changeToMainWindow ??
                    (changeToMainWindow = new Command(obj =>
                    {
                        WindowBuilder.ShowMainWondow();
                        CloseWindow();
                    }));
            }
        }
        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty);
    }
}
