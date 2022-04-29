using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GameStore.Commands;
using GameStore.Vews;

namespace GameStore.ViewModel
{
    class MainWindowModel
    {
        public event EventHandler EventCloseWindow;
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
    }
}
