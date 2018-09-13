using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EyeAppoint.Views
{
	public class NoInternetPage : ContentPage
	{
        Image splashImage;

        public NoInternetPage()
		{
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image
            {
                Source = "nointernet.png"
               
            };
            AbsoluteLayout.SetLayoutFlags(splashImage,
               AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
             new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#ffffff");
            this.Content = sub;
        }

    }
}