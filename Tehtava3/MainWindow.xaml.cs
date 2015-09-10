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

namespace Tehtava3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Player> players = new List<Player>();
        }

        private void cbTeam_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> teams = new List<string>();
            teams.Add("TPS");
            teams.Add("Lukko");
            teams.Add("Ässät");
            teams.Add("HIFK");
            teams.Add("Blues");
            teams.Add("HPK");
            teams.Add("Tappara");
            teams.Add("Ilves");
            teams.Add("Sport");
            teams.Add("Pelicans");
            teams.Add("KooKoo");
            teams.Add("SaiPa");
            teams.Add("Kärpät");
            teams.Add("JYP");
            teams.Add("KalPa");

            var cbTeam = sender as ComboBox;

            cbTeam.ItemsSource = teams;

            cbTeam.SelectedIndex = 0;
        }

        private void btnCreateNewPlayer_Click(object sender, RoutedEventArgs e, List<Player> players)
        {
            bool matchFound = false;
            if(tbFristName.Text != "" && tbSurName.Text != "" && tbTradePrice.Text != "")
            {
                for (int i = 0; i < players.Count; i++) 
                {
                    if (players[i].FullName == (tbFristName.Text + " " + tbSurName.Text + ", " + cbTeam.Text))
                    {
                        matchFound = true;
                    }
                }

                if (matchFound == false)
                {
                    players.Add()
                }
            }
        }
    }
}
