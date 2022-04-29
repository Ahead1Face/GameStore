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
    }
}
