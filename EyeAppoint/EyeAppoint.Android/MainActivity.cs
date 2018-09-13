

using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;

namespace EyeAppoint.Droid
{
    [Activity(Label = "EyeAppoint", Icon = "@drawable/icon", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
     public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);
            //   
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            //global::Xamarin.Forms.Application.Current.On<Xamarin.Forms.PlatformConfiguration.Android>()
            //      .UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);

            LoadApplication(new App());
        }
    }
}