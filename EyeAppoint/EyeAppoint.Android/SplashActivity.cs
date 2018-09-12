﻿
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace EyeAppoint.Droid
{
    [Activity(Label = "Eye Appoint",
              Icon = "@drawable/icon",
              Theme = "@style/Theme.Splash", //Indicates the theme to use for this activity
              MainLauncher = true, //Set it as boot activity
              NoHistory = true)] //Doesn't place it in back stack
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            System.Threading.Thread.Sleep(3000); //Let's wait awhile...
            this.StartActivity(typeof(MainActivity));
        }
    }
}
