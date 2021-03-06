﻿using System;
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

namespace Godsamme
{
   
    public partial class MainWindow : Window
    {
        private const int NR_OF_COLS = 4;
        private const int NR_OF_ROWS = 4;

        Random rnd = new Random();

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
        }




    }
}


