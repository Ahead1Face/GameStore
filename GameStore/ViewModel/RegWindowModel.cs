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
    class RegWindowModel
    {
        private Command changeToMainWindow;
        public event EventHandler EventCloseWindow;
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
