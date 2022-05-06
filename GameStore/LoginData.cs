using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GameStore
{
    class LoginData
    {
        public static int Id{get;set;}
        public static string Login{get;set;}
        public static string UserEmail{get; set;}

        public static void MoveStore(int newID, string login,string Email)
        {
            Id = newID;
            Login = login;
            UserEmail = Email;
            WindowBuilder.ShowStoreWindow();
        }
        public static bool CheckLogin(string loginString) 
        { 
            Regex rx = new Regex(@"^[a-zA-Z](.[a-zA-Z0-9_-]*)$"); 
            return rx.IsMatch(loginString); 
        }
 
        public static bool CheckPassword(string passwordString) 
        { 
            Regex rx = new Regex(@"^(?=.*[0-9])(?=.*[!@#$%^&*])(?=.*[a-z])(?=.*[A-Z])[0-9a-zA-Z!@#$%^&*]{6,}$"); 
            return rx.IsMatch(passwordString); 
        } 
 
        public static bool CheckEmail(string emailString) 
        { 
            Regex rx = new Regex(@"^((([0-9A-Za-z]{1}[-0-9A-z\.]{1,}[0-9A-Za-z]{1})|([0-9А-Яа-я]{1}[-0-9А-я\.]{1,}[0-9А-Яа-я]{1}))@([-A-Za-z]{1,}\.){1,2}[-A-Za-z]{2,})$"); 
            return rx.IsMatch(emailString); 
        }
    }
}
