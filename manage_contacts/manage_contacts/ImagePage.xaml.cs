using ImageCircle.Forms.Plugin.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace manage_contacts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();

            //var imageSource = (UriImageSource)ImageSource.FromUri(new Uri("http://"));

            //var imageSource = new UriImageSource
            //{
            //    Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/")
            //};

            //imageSource.CachingEnabled = false;
            //imageSource.CacheValidity = TimeSpan.FromHours(1);

            //bkgImage.Source = imageSource;

            //bkgImage.Source = ImageSource.FromResource("manage_contacts.Images.background.jpg");

            //bkgImage.Aspect = Aspect.Fill;

            //switch(Device.RuntimePlatform)
            //{
            //    case Device.iOS :
            //    case Device.Android:
            //        btnImage.Image = (FileImageSource)ImageSource.FromFile("clock.png");
            //        break;
            //    case Device.WinPhone:
            //        btnImage.Image = (FileImageSource)ImageSource.FromFile("Images/clock.png");
            //        break;
            //}

            var imageCircle = new CircleImage
            {
                BorderColor = Color.White,
                BorderThickness = 3,
                HeightRequest = 150,
                WidthRequest = 150,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                //Source = UriImageSource.FromUri(new Uri("http://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG"))
                Source = ImageSource.FromResource("manage_contacts.Images.background.jpg")
        };

            var layout = new StackLayout();

            layout.HorizontalOptions = LayoutOptions.Center;
            layout.VerticalOptions = LayoutOptions.Center;
            layout.Children.Add(imageCircle);

            Content = layout;

        }
	}
}