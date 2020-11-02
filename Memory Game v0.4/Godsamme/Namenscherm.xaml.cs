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
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }


        //! Met deze Functie worden de namen die zijn ingevoerd overgebracht naar de MainWindow waar deze worden weergegeven.
        //! Ook wordt het Namenscherm afgesloten en de MainWindow weergegeven.
        private void startbutton_Click(object sender, RoutedEventArgs e)
        {
            string naam1 = Speler1.Text;
            string naam2 = Speler2.Text;
            MainWindow mainWindow = new MainWindow(naam1, naam2);
            mainWindow.Show();
            this.Close();
        }


        //! Met deze functie wordt het huidige scherm afgesloten en wordt de Titlescreen weergegeven.
        private void Terugbutton_Click(object sender, RoutedEventArgs e)
        {
            var Titlescreen = new Titlescreen();
            Titlescreen.Show();
            this.Close();
        }

        
        //! Met deze twee functies wordt de placeholder text verwijderd en kan de gebruiker een naam invullen.
        private void Speler1_GotFocus(object sender, RoutedEventArgs e)
        {
            if(Speler1.Text != "Username player one")
            {
               
            }
            else
            {
                Speler1.Text = "";
                Speler1.Foreground = Brushes.Black;
            }
        }
        private void Speler2_GotFocus(object sender, RoutedEventArgs e)
        {
            if (Speler2.Text != "Username player two")
            {

            }
            else
            {
                Speler2.Text = "";
                Speler2.Foreground = Brushes.Black;
            }
        }

  
        //! Met deze twee functies wordt gecontroleerd of de gebruiker een naam heeft ingevoerd. 
        //! Is dit niet het geval dan zal de placeholder text weer te voorschijn komen
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
