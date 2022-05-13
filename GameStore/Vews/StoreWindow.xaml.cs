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
using GameStore.Model;

namespace GameStore.Vews
{
    /// <summary>
    /// Логика взаимодействия для StoreWindow.xaml
    /// </summary>
    public partial class StoreWindow : Window
    {
        public StoreWindow()
        {
            InitializeComponent();
            StoreBorder windowBorder = new StoreBorder(this);
            windowBorder.SetValue(Grid.RowProperty, 0);
            StoreGrid.Children.Add(windowBorder);
            FillGrid();
        }
        void FillGrid()
        {
            using(DBStore db = new DBStore())
            {
                List<RowDefinition> rows = new List<RowDefinition>();
                int gameCount = db.Game.Count();
                int rowsCount = (gameCount +1) / 2;
                for(int i = 0; i < rowsCount; i++)
                {
                    rows.Add(new RowDefinition());
                    rows[i * 2].Height = new GridLength(30);
                    rows.Add(new RowDefinition());
                    rows[i * 2 + 1].Height = new GridLength(130, GridUnitType.Star);
                }
                rows.Add(new RowDefinition());
                rows[rowsCount - 1].Height = new GridLength(30);

                for (int i = 0; i < rows.Count; i++)
                {
                    GameGrid.RowDefinitions.Add(rows[i]);
                }

                int columnNum = 1;
                int rowNum = 1;
                int index = 0;
                foreach(Game game in db.Game)
                {
                    StackPanel sp = new StackPanel();
                    sp.SetValue(Grid.RowProperty, rowNum);
                    sp.SetValue(Grid.ColumnProperty, columnNum);

                    Label price = new Label();
                    price.HorizontalAlignment = HorizontalAlignment.Center;
                    price.Content = game.Price + "$";

                    Label Name = new Label();
                    Name.HorizontalAlignment = HorizontalAlignment.Center;
                    Name.Content = game.Name;
                    Image currentImage = new Image();
                    BitmapImage Logo = DataTransform.ByteToImage(game.Image);
                    currentImage.Source = Logo;
                    columnNum = (columnNum == 1) ? 3 : 1;

                    sp.Children.Add(currentImage);
                    sp.Children.Add(Name);
                    sp.Children.Add(price);
                    GameGrid.Children.Add(sp);

                    if((index +1) %2 == 0)
                    {
                        rowNum += 2;
                    }
                    index++;
                }
            }
        }
    }
}
