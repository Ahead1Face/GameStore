using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GameStore.CustomControll
{
    /// <summary>
    /// Логика взаимодействия для WindowsBorder.xaml
    /// </summary>
    public partial class WindowsBorder : UserControl
    {
        Window parent;
        public WindowsBorder(Window parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        private void bHide_Click(object sender, RoutedEventArgs e)
        {
            this.parent.WindowState = WindowState.Minimized;
        }
        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.parent.Close();
        }

        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                parent.DragMove();
        }
    }
}
