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
	public partial class ContactMasterDetailPage : MasterDetailPage
	{
        public ContactMasterDetailPage ()
		{
			InitializeComponent();
            listView.ItemsSource = GetContacts();
            Master.Title = "Contacts";
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            Detail = new ContactDetailsPage(contact);
            IsPresented = false; // Hiding Master
        }

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
    }
}