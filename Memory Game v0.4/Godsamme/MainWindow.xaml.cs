using System;
using System.Collections.Generic;
using System.IO;
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

        public bool PlayerCount = true;
        public int Player1Score = 0;
        public int Player2Score = 0;

        public MainWindow(string naam1, string naam2)
        {
            InitializeComponent();

            InitializeGameGrid(NR_OF_ROWS, NR_OF_COLS);

            AddImages(NR_OF_COLS, NR_OF_ROWS);

            Speler1.Text = naam1;
            Speler2.Text = naam2;
            PlayerTurn.Text = Speler2.Text;
        }


        //Hier wordt het speelveld van 4 bij 4 kaarten aangemaakt.
        //Er wordt gebruik gemaakt van rows en cols die eerder gedefineerd zijn als 4. 
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

        //Hier worden de achterkanten van de kaarten ingeladen en verdeeld over de cols en rows.
        //Ook de mouseclick event is aangemaakt voor het draaien van kaarten.
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

        //Hier worden de voorkanten van de kaarten ingeladen en geshuffled in een willekeurige volgorde.
        //Zo komen ze ook willekeurig in de gamegrid te staan.
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
            //Hier wordt het omdraaien van de kaartjes mogelijk gemaakt.
            //Ook worden de laatste 5 cijfer/letters van de imagename gepakt zodat als er twee dezelfe aangeklikt worden er een match is.
            Image card = (Image)sender;
            ImageSource front = (ImageSource)card.Tag;
            card.Source = front;
            string imagename = card.Tag.ToString();
            imagename = imagename.Substring(imagename.Length - 5);

            //Gematchde kaarten worden onzichtbaar gemaakt en zijn daarom niet meer aanklikbaar.
            if (card.Opacity == 0)
            {
                return;
            }
            //Deze twee loops zorgen er voor dat je maar op twee kaarten kan klikken.
            if (first == null)
            {
                first = card;
                return;
            }
            if (second == null)
            {
                second = card;

            }
            //Als de namen van de image hetzelfde zijn is het een match.
            //Kaarten worden dan onzichtbaar gemaakt zodat ze niet meer meedoen aan het spel.
            if (first.Tag.ToString() == second.Tag.ToString())
            {
                MessageBox.Show("Match!");
                first.Opacity = 0;
                second.Opacity = 0;
                first = null;
                second = null;
                //Met deze twee statements wordt een punt gegeven aan een speler die 2 kaarten gematched heeft en wordt de beurt doorgegeven aan de volgende speler.
                //Ook wordt de text in de scoreblokken dynamisch aangepast en weergegeven wie aan de beurt is.
                if (PlayerCount == true)
                {
                    PlayerTurn.Text = Speler1.Text;
                    Player2Score++;
                    PlayerCount = false;
                }
                else if (PlayerCount == false)
                {
                    PlayerTurn.Text = Speler2.Text;
                    Player1Score++;
                    PlayerCount = true;
                }
                HS1.Text = Player1Score.ToString();
                HS2.Text = Player2Score.ToString();
                
            }
            //Als de image namen niet hetzelfde zijn krijgt de speler een melding dat het geen match is.
            //Daarna worden de kaarten weer teruggedraaid naar de afbeelding van de achterkant.
            else if (first.Tag.ToString() != second.Tag.ToString())
            {
                MessageBox.Show("No Match!");

                Uri path = new Uri("Resources/Achterkant.png", UriKind.Relative);
                first.Source = new BitmapImage(path);
                second.Source = new BitmapImage(path);

                first = null;
                second = null;
                //Met deze twee statements wordt de beurt doorgegeven aan de volgende speler als er twee niet matchende kaarten omgedraaid zijn.
                //Ook wordt weergegeven wie aan de beurt is.
                if (PlayerCount == true)
                {
                    PlayerTurn.Text = Speler1.Text;
                    PlayerCount = false;
                }
                else if (PlayerCount == false)
                {
                    PlayerTurn.Text = Speler2.Text;
                    PlayerCount = true;
                }
            }
            else
            {
                first = null;
                second = null;
            }
            //Zodra een speler een score van 5 matches heeft gehaald, krijgt de speler een melding dat hij/zij heeft gewonnen. 5 matches = 10 kaarten 
            if (Player1Score == 5)
            {
                MessageBox.Show(Speler1.Text + " wins !");


            }
            else if (Player2Score == 5)
            {
                MessageBox.Show(Speler2.Text + " wins !");
            }
            
            if (Player1Score == 4 && Player2Score == 4)
            {
                MessageBox.Show("It's a draw! Click the restart button to play again.");
            }
                
                 
            

            
                

            
            
            }


        // Met deze funtie wordt het spel gereset en kan er opnieuw gespeeld worden.
        private void RestartBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Are you sure you want to restart?");
            var mainwindow = new MainWindow(Speler1.Text , Speler2.Text);
            mainwindow.Show();
            this.Close();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            var titlescreen = new Titlescreen();
            titlescreen.Show();
            this.Close();
        }

        // Hiermee wordt een nieuw .sav file aangemaakt als deze nog niet aanwezig is
        // Hiermee wordt het speelveld opgeslagen in het .sav file
        // Ook worden de scores en welke speler aan de beurt is opgeslagen in het .sav file.

        private void SaveGame_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your scores have been saved");
            using (StreamWriter w = File.AppendText("memory.sav"))
            using (var writer = new StreamWriter("memory.sav"))
            {
                writer.WriteLine(PlayerCount);
                writer.WriteLine(Player1Score);
                writer.WriteLine(Player2Score);
                writer.WriteLine();
            } 

        }
        




        

    }
}
