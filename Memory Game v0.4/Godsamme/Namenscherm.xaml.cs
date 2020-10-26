using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void startbutton_Click(object sender, RoutedEventArgs e)
        {
            string naam1 = Speler1.Text;
            string naam2 = Speler2.Text;
            MainWindow mainWindow = new MainWindow(naam1, naam2);
            mainWindow.Show();
            Speler1.Text = mainWindow.naam1;
            Speler2.Text = mainWindow.naam2;
            this.Close();

        }


        private void Terugbutton_Click(object sender, RoutedEventArgs e)
        {
            var Titlescreen = new Titlescreen();
            Titlescreen.Show();
            this.Close();
        }
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
    }

    }
