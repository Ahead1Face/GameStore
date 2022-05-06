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
using GameStore.Model;
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
                OnPropertyChanged("NewUserLogin");
            }
        }

        public string NewUserEmail
        {
            get { return newUserEmail; }
            set
            {
                newUserEmail = value;
                OnPropertyChanged("NewUserEmail");
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

        private Command addNewUser;
        public Command AddNewUser
        {
            get
            {
                return addNewUser ??
                    (addNewUser = new Command(obj =>
                    {
                        using(DBStore db = new DBStore())
                        {
                            PasswordBox pb = (PasswordBox)obj;
                            string? password = pb.Password;
                            User? user = db.User.Where(u => u.Login == newUserLogin).FirstOrDefault();

                            if(user == null && LoginData.CheckLogin(newUserLogin) && 
                            LoginData.CheckEmail(newUserEmail) && LoginData.CheckPassword(pb.Password))
                            {
                                int maxId = db.User.Max(u => u.Id);
                                User newUser = new User(maxId +1, newUserLogin, newUserEmail, password);
                                db.User.Add(newUser);
                                db.SaveChanges();
                                LoginData.MoveStore(maxId +1, newUserLogin,newUserEmail);
                                CloseWindow();
                            }
                            else
                            {
                            MessageBox.Show("Пользователь уже существует или данные неверные");
                            }
                        }   
                    }));
            }
        }
    }
}
