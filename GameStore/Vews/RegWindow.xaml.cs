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
using System.Windows.Shapes;
using GameStore.CustomControll;
using GameStore.ViewModel;

namespace GameStore.Vews
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
            WindowsBorder windowBorder = new WindowsBorder(this);
            windowBorder.SetValue(Grid.RowProperty, 0);
            Grid1.Children.Add(windowBorder);
        }

        private void B_Back_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool res = LoginData.CheckLogin(TBLogin.Text);
            TBLogin.Foreground = res ? new SolidColorBrush(Colors.Green) : new SolidColorBrush(Colors.Red);
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            bool res = LoginData.CheckEmail(TBEmail.Text);
            TBEmail.Foreground = res ? new SolidColorBrush(Colors.Green) : new SolidColorBrush(Colors.Red);
        }

        private void pb1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            bool res = LoginData.CheckPassword(pb1.Password);
            pb1.Foreground = res ? new SolidColorBrush(Colors.Green) : new SolidColorBrush(Colors.Red);
        }
    }
}
