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
using System.Windows.Shapes;

namespace Godsamme
{
    /// <summary>
    /// Interaction logic for highscores.xaml
    /// </summary>
    public partial class highscores : Window
    {
        public highscores()
        {
            InitializeComponent();
        }

        private void highscoresBtn_Click(object sender, RoutedEventArgs e)
        {
            var Titlescreen = new Titlescreen();
            Titlescreen.Show();
            this.Close();
            
        }
    }
}
