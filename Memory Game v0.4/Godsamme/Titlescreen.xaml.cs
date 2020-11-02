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

namespace Godsamme
{
    //! <summary>
    //! Interaction logic for Titlescreen.xaml
    //! </summary>
    public partial class Titlescreen : Window
    {
        public Titlescreen()
        {
            InitializeComponent();
        }
        //! Deze button start het spel
        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            var Namenscherm = new Window1();
            Namenscherm.Show();
            this.Close();
        }

        //! Deze button eindigt het spel

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Are you sure you want to exit?");
            this.Close();
        }

        private void highscoresBtn_Click(object sender, RoutedEventArgs e)
        {
            var highscores = new highscores();
            highscores.Show();
            this.Close();
        }

        private void loadBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Load Game");
        }
        
    }
}
