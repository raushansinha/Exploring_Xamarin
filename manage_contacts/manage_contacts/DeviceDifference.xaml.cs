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
	public partial class DeviceDifference : ContentPage
	{
		public DeviceDifference()
		{
            InitializeComponent();
            slider.Value = 0.5;

            //if (Device.OS == TargetPlatform.iOS)
            //    Padding = new Thickness(0, 20, 0, 0);

            //else if (Device.OS == TargetPlatform.Android)
            //    Padding = new Thickness(0, 50, 0, 0);

            //Same as above
            //Padding = Device.OnPlatform(
            //    iOS: new Thickness(0, 20, 0, 0),
            //    Android: new Thickness(0, 50, 0, 0),
            //    WinPhone: new Thickness(20, 20, 0, 0)
            //);

            //Device.OnPlatform(
            //    Android: () =>
            //    {

            //    },
            //     iOS: () =>
            //     {

            //     });

            switch(Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
                case Device.Android:
                    Padding = new Thickness(10, 10, 0, 0);
                    break;
            }

        }
    }
}