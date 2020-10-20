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

namespace MemoryGame27
{
    <summary>
    Interaction logic for MainWindow.xaml
    </summary>
    public partial class MainWindow : Window
    {
        private const int NR_OF_COLS = 4;
        private const int NR_OF_ROWS = 4;

        public MainWindow()
        {
            InitializeComponent();
            InitializeGameGrid(NR_OF_ROWS, NR_OF_COLS);

            AddLabel();

            Image backgroundImage = new Image();
            Uri path = new Uri("Resources/Baidu.png", UriKind.Relative);
            backgroundImage.Source = new BitmapImage(path);
            Grid.SetColumn(backgroundImage, 2);
            Grid.SetRow(backgroundImage, 0);
            GameGrid.Children.Add(backgroundImage);

            AddImages(NR_OF_COLS, NR_OF_ROWS);

        }
        private void InitializeGameGrid(int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                GameGrid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < cols; i++)
            {
                GameGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        private void AddLabel()
        {
            Label title = new Label();
            title.Content = "My Game";
            title.FontFamily = new FontFamily("Comic sans");
            title.FontSize = 40;
            title.HorizontalContentAlignment = HorizontalAlignment.Center;

            Grid.SetColumn(title, 1);
            GameGrid.Children.Add(title);
        }

        private void AddImages(int rows, int cols)
        {
            List<ImageSource> images = GetImageList();
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Image backgroundImage = new Image();
                    backgroundImage.Source = new BitmapImage(new Uri("Resources/Achterkant.png", UriKind.Relative));
                    backgroundImage.Tag = images.First();
                    images.RemoveAt(0);
                    backgroundImage.MouseDown += new MouseButtonEventHandler(TurnCard);
                    Grid.SetColumn(backgroundImage, c);
                    Grid.SetRow(backgroundImage, r);
                    GameGrid.Children.Add(backgroundImage);

                }
            }
        }
        private void CardClick(object sender, MouseButtonEventArgs e)
        {
            Image card = (Image)sender;
            ImageSource front = (ImageSource)card.Tag;
            card.Source = front;
        }

        private List<ImageSource> GetImageList()
        {
            List<ImageSource> images = new List<ImageSource>();
            for (int i = 0; i < 16; i++)
          {
                int imageNr = i % 8 + 1;
                ImageSource source = new BitmapImage(new Uri("Resources/" + imageNr + ".png", UriKind.Relative));
              
            }
            
           
        }
        private void TurnCard(object sender, MouseButtonEventArgs e)
        {
            Image card = (Image)sender;
            ImageSource front = (ImageSource)card.Tag;
            card.Source = front;
        }
    }
}




