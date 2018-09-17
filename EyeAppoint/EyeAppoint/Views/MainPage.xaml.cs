
using System;
using System.Data;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Connectivity;

namespace EyeAppoint.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            InitializeComponent();
            if(CrossConnectivity.Current.IsConnected)
            {
               Browser.Source = "https://cyclopsodyssey.com/pwa";
			}

        }
        void webOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            if (!e.Url.Contains("cyclopsodyssey"))
            {
                try
                {
                    var uri = new Uri(e.Url);
                    Device.OpenUri(uri);
                }
                catch (Exception)
                {
                }

                e.Cancel = true;
            }
        }
        void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
        {
        }
    }
}