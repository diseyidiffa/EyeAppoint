using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.Connectivity;
using EyeAppoint.Views;
using AndroidSpecific = Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace EyeAppoint
{
    public partial class App : Application
    {

        public App()
        {
            AndroidSpecific.Application.SetWindowSoftInputModeAdjust(this, AndroidSpecific.WindowSoftInputModeAdjust.Resize);

            InitializeComponent();
            CrossConnectivity.Current.ConnectivityChanged += (sender, args) =>
            {
                if (args.IsConnected)
                {
                    MainPage = new MainPage();
                }
                else
                {
                    MainPage = new NoInternetPage();
                }
            };
            MainPage = new MainPage();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
