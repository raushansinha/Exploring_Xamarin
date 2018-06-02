using manage_contacts.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace manage_contacts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListPage : ContentPage
	{
        private ObservableCollection<ContactGroup> _contactGroups;
		public ListPage ()
		{
			InitializeComponent ();

            //contacts.ItemsSource = new List<Contact>
            //{
            //    new Contact{ Name="Reyansh", ImageUrl="https://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG"},
            //    new Contact{ Name="Anita", ImageUrl="https://cdn.pixabay.com/photo/2018/05/07/10/48/husky-3380548_960_720.jpg", Status="Birthday Photo"},
            //    new Contact{ Name="Raushan", ImageUrl="https://cdn.pixabay.com/photo/2018/04/30/18/09/stork-3363503_960_720.jpg", Status="Kala chasma"}
            //};

            _contactGroups = new ObservableCollection<ContactGroup>
            {
            new ContactGroup("A", "A")
                {
                     new Contact{ Name="Anita", ImageUrl="https://cdn.pixabay.com/photo/2018/05/07/10/48/husky-3380548_960_720.jpg", Status="Birthday Photo"}
                },
                new ContactGroup("P", "P")
                {
                    new Contact{ Name="Prakash", ImageUrl="https://cdn.pixabay.com/photo/2018/04/30/18/09/stork-3363503_960_720.jpg", Status="Kala chasma"}

                },
                new ContactGroup("R", "R")
                {
                     new Contact{ Name="Reyansh", ImageUrl="https://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG"},
                     new Contact{ Name="Raushan", ImageUrl="https://cdn.pixabay.com/photo/2018/04/30/18/09/stork-3363503_960_720.jpg", Status="Kala chasma"},
                     new Contact{ Name="Rajat", ImageUrl="https://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG"},

                }
            };

            contacts.ItemsSource = _contactGroups;
        }

        private void contacts_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //var contact = e.Item as Contact;
            //DisplayAlert("Tapped", contact.Name, "OK");
        }

        private void contacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "OK");

            //To disable selection
            contacts.SelectedItem = null;
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", contact.Name, "OK");
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            DisplayAlert("Delete", contact.Name, "OK");

        }
    }
}