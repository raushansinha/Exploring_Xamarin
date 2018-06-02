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
	public partial class GridPage : ContentPage
	{
        //Position elements in rows and columns
		public GridPage ()
		{
			InitializeComponent ();

            string alphabets = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            var Grid = new Grid
            {
                RowSpacing = 2,
                ColumnSpacing = 5,
                BackgroundColor = Color.Gray
            };

            int row = 0;
            foreach(var letter in alphabets)
            {
                var label = new Label { Text = letter.ToString()};
                Grid.Children.Add(label, 1, row);
                Grid.RowDefinitions.Add(new RowDefinition
                {
                    Height = new GridLength(row++, GridUnitType.Auto)
                });
            }

            var label2 = new Label { Text = "Raushan Sinha" };
            Grid.Children.Add(label2, 0, 0);
            Grid.SetRowSpan(label2, 10);
            // Grid.SetColumn

            //Grid.RowDefinitions.Add(new RowDefinition
            //{
            //    Height = new GridLength(1, GridUnitType.Auto)
            //});

            Grid.ColumnDefinitions.Add(new ColumnDefinition
            {
                Width = new GridLength(9, GridUnitType.Star)
            });


            Content = Grid;
		}
	}
}