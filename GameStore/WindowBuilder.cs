using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Vews;
using GameStore.ViewModel;

namespace GameStore
{
    class WindowBuilder
    {
        public static void ShowMainWondow()
        {
            var mainWindow = new MainWindow();
            var viewModel = new MainWindowModel();
            mainWindow.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { mainWindow.Close(); };
            mainWindow.Show();
        }

        public static void ShowRegWindow()
        {
            var regwindow = new RegWindow();
            var viewModel = new MainWindowModel();
            regwindow.DataContext = viewModel;
            viewModel.EventCloseWindow += (sender, args) => { regwindow.Close(); };
            regwindow.Show();
        }
    }
}
