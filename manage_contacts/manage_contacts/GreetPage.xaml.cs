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
	public partial class GreetPage : ContentPage
	{
		public GreetPage ()
		{
            Content = new Label
            {
                HorizontalOptions = LayoutOptions.Center,
                Text = "Hello World"
            };
            InitializeComponent();
            slider.Value = 0.5;
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Title", "Hello World", "Ok");
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            lblSliderValue.Text = string.Format("Value is {0:F2}", e.NewValue);
        }
    }
}