
using Newtonsoft.Json;
using System;
using System.Data;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EyeAppoint.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            string Url = "https://cyclopsodyssey.com/pwa/server/server.php?action=getContactLens&fkcompanyid=95";

            var client = new HttpClient();
            var json =  client.GetAsync(Url);
          //  var responseJson = json.Result.Content.ReadAsStringAsync().Result;
          //  var msg -JsonConvert.DeserializeObject<DataTable>(responseJson);
        //   JsonConvert.DeserializeObject<Product>(json.ToString());
            InitializeComponent();
           //if (CrossConnectivity.Current.IsConnected)
            {

            Browser.Source = "https://cyclopsodyssey.com/pwa";
			}

        }
    }
}