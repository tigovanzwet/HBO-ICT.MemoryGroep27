using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
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

namespace Godsamme
{
   
    public partial class MainWindow : Window
    {
        private const int NR_OF_COLS = 4;
        private const int NR_OF_ROWS = 4;

        Random rnd = new Random();

        Image first = null;
        Image second = null;

        public MainWindow()
        {
            InitializeComponent();

            InitializeGameGrid(NR_OF_ROWS, NR_OF_COLS);

            AddImages(NR_OF_COLS, NR_OF_ROWS);
        }

        private void InitializeGameGrid(int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                GameGrid.RowDefinitions.Add(new RowDefinition());
            }
            {
                for (int i = 0; i < cols; i++)
                {
                    GameGrid.ColumnDefinitions.Add(new ColumnDefinition());
                }
            }
        }
        private void AddImages(int rows, int cols)
        {
            List<ImageSource> images = getImageList();
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Image backgroundImage = new Image();
                    Uri path = new Uri("Resources/Achterkant.png", UriKind.Relative);
                    backgroundImage.Source = new BitmapImage(path);
                    backgroundImage.Tag = images.First();
                    images.RemoveAt(0);
                    backgroundImage.MouseDown += new MouseButtonEventHandler(TurnCard);
                    Grid.SetColumn(backgroundImage, c);
                    Grid.SetRow(backgroundImage, r);
                    GameGrid.Children.Add(backgroundImage);
                }
            }
        }
        private List<ImageSource> getImageList()
        {
            List<ImageSource> result = new List<ImageSource>();
            for (int i = 0; i < 16; i++)
            {
                int nr = i % 8 + 1;

                Uri path = new Uri("Resources/" + nr + ".png", UriKind.Relative);
                result.Add(new BitmapImage(path));

            }
            var shuffled = result.OrderBy(x => Guid.NewGuid()).ToList();
            return shuffled;

            

        }
        
        private void TurnCard(object sender, MouseButtonEventArgs e)
        {
            Image card = (Image)sender;
            ImageSource front = (ImageSource)card.Tag;
            card.Source = front;
            string imagename = card.Tag.ToString();
            imagename = imagename.Substring(imagename.Length - 5);

            if (card.Opacity == 0)
            {
                return;
            }  
            if (first == null)
            {
                first = card;
                return;
            }
            if (second == null)
            {
                second = card;

            }
            if (first.Tag.ToString() == second.Tag.ToString())
            {
                MessageBox.Show("Match!");
                first.Opacity = 0;
                second.Opacity = 0;
                first = null;
                second = null;
            }
            else if (first.Tag.ToString() != second.Tag.ToString())
            {
                MessageBox.Show("No Match!");
               
                Uri path = new Uri("Resources/Achterkant.png", UriKind.Relative);
                first.Source = new BitmapImage(path);
                second.Source = new BitmapImage(path);

                first = null;
                second = null;

                

            }
            else
            {
                first = null;
                second = null;
            }

        }
        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Are you sure you want to restart?");
            var MainWindow = new MainWindow();
            MainWindow.Show();
            this.Close();

        }




        //Tijdelijk : wordt nog verandert dus >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
        private void Speler1_GotFocus(object sender, RoutedEventArgs e)
        {
            Speler1.Text = "";
            Speler1.Foreground = Brushes.Black;

        }

        private void Speler2_GotFocus(object sender, RoutedEventArgs e)
        {
            Speler2.Text = "";
            Speler2.Foreground = Brushes.Black;

        }


        private void Speler1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Speler1.Text == "")
            {
                Speler1.Text = "Username player one";
                Speler1.Foreground = Brushes.Gray;
            }


        }

        private void Speler2_LostFocus(object sender, RoutedEventArgs e)
        {
            if (Speler2.Text == "")
            {
                Speler2.Text = "Username player two";
                Speler2.Foreground = Brushes.Gray;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Are you sure you want to go back to the main menu?");
            var Titlescreen = new Titlescreen();
            Titlescreen.Show();
            this.Close();
        }
    }
    // Tijdelijk >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>


}
