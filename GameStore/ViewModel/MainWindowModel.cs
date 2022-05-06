using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using GameStore.Commands;
using GameStore.Vews;

namespace GameStore.ViewModel
{
    class MainWindowModel : INotifyPropertyChanged
    {
        string currentUserLogin;

        public event EventHandler EventCloseWindow;

        public event PropertyChangedEventHandler? PropertyChanged;
        public string CurrentUserLogin
        {
            get{return currentUserLogin;}
            set
            {
                currentUserLogin = value;
                OnPropertyChanged("CurrentUserLogin");
            }
        }
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private Command changeToRegWindow;
        public Command ChangeToRegWindow
        {
            get
            {
                return changeToRegWindow ??
                    (changeToRegWindow = new Command(obj =>
                    {
                        WindowBuilder.ShowRegWindow();
                        CloseWindow();
                    }));
            }
        }
        public void CloseWindow() => EventCloseWindow?.Invoke(this, EventArgs.Empty); 

        private Command loginUser;
        public Command LoginUser
        {
            get
            {
                return loginUser ??
                    (loginUser = new Command(obj =>
                    {
                        PasswordBox pb = (PasswordBox)obj;
                        using (DBStore db = new DBStore())
                        {
                            var users = db.User.ToList();
                            var user = users.Where(u => u.Login == currentUserLogin
                                                   && u.Password == pb.Password).FirstOrDefault();
                            if(user != null)
                            {
                                LoginData.MoveStore(user.Id, user.Login, user.Email);
                                CloseWindow();
                            }
                            else
                            {
                                MessageBox.Show("Пользователь не найден");
                            }
                        }
                    }));
            }
        }


        
    }
}
