using manage_contacts.Models;
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
	public partial class ContactPage : ContentPage
	{
        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>
            {
                  new Contact{ Name="Reyansh", ImageUrl="https://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG"},
                  new Contact{ Name="Raushan", ImageUrl="https://cdn.pixabay.com/photo/2018/04/30/18/09/stork-3363503_960_720.jpg", Status="Kala chasma"},
                  new Contact{ Name="Anita", ImageUrl="https://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG"},
                  new Contact{ Name="Prakash", ImageUrl="https://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG"}
            };

            if (string.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(x => x.Name.ToLower().StartsWith(searchText));
        }

        public ContactPage ()
		{
			InitializeComponent ();
            listView.ItemsSource = GetContacts();
        }

        private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            var contact = e.Item as Contact;
            //DisplayAlert("Tapped", contact.Name, "OK");
            await Navigation.PushAsync(new ContactDetailsPage(contact));
            listView.SelectedItem = null;
        }
    }
}