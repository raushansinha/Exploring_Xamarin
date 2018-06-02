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
	public partial class DataBinding : ContentPage
	{
		public DataBinding()
		{
            InitializeComponent();
            slider.Value = 0.5;
		}

        //private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    lblSliderValue.Text = string.Format("Value is {0:F2}", e.NewValue);
        //}
    }
}