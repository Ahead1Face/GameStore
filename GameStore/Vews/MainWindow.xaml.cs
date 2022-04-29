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
using GameStore.CustomControll;
using GameStore.ViewModel;

namespace GameStore.Vews
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowsBorder windowBorder = new WindowsBorder(this);
            windowBorder.SetValue(Grid.RowProperty, 0);
            MainGrid.Children.Add(windowBorder);
        }

        private void bReg_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
