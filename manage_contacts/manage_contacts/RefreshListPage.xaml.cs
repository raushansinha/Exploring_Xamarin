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
	public partial class RefreshListPage : ContentPage
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

        public RefreshListPage()
        {
            InitializeComponent();
            listView.ItemsSource = GetContacts();
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();
            //listView.IsRefreshing = false; or
            listView.EndRefresh();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource =  GetContacts(e.NewTextValue);
        }
    }
}