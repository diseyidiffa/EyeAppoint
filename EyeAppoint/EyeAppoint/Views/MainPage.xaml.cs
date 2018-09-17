
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
    }
}