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
using IzingaWebClient.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Globalization;

namespace IzingaWebClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<Event> CollectionforListView { get; set; }
        static HttpClient client = new HttpClient();
        public MainWindow()
        {
            RunAsync().Wait();
            client.BaseAddress = new Uri("http://localhost:3139/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            InitializeComponent();
        }

        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("http://localhost:3139/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        static async Task<List<Event>> GetProductAsync(string path)
        {
            List<Event> incident = new List<Event>();
            incident = null;

            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsAsync<string>();
                incident = JsonConvert.DeserializeObject<List<Event>>(json);
            }
            return incident;
        }

        private async void Fetchlog_Click(object sender, RoutedEventArgs e)
        {
            connectionErrorTextBlock.Visibility = Visibility.Hidden;

            try
            {
                CollectionforListView = await GetProductAsync("api/log/getlog");

                foreach (Event _event in CollectionforListView)
                {
                    listView.Items.Add(_event);
                }
            }
            catch (Exception)
            {
                connectionErrorTextBlock.Visibility = Visibility.Visible;
            }
        }
    }
}
