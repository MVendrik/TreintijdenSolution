using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using TreintijdenSolution.Models;


namespace TreintijdenSolution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private async void Stations_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Station st = lbxStations.SelectedItem as Station;

            HttpClient client = new HttpClient();

            string content = await client.GetStringAsync("http://xanderwemmers.nl/api/ns/" + st.Code);

            List<Vertrektijden> alleTijden = JsonConvert.DeserializeObject<List<Vertrektijden>>(content);

            DgTreintijden.ItemsSource = alleTijden;

 
        }

        private async void WindowLoaded(object sender, RoutedEventArgs e)
        {

            //maak http client aan
            HttpClient client = new HttpClient();

            // maak een lange string van het json formaat
            string content = await client.GetStringAsync("http://xanderwemmers.nl/api/ns/");

            List<Station> AlleStations = JsonConvert.DeserializeObject<List<Station>>(content);

            lbxStations.ItemsSource = AlleStations;


        }
    }
}
