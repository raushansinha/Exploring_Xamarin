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
	public partial class ContactDetailsPage : ContentPage
	{
        Contact _contact;
		public ContactDetailsPage ( Contact contact)
		{
            if (contact == null)
                throw new ArgumentException();

            BindingContext = contact;

			InitializeComponent ();

            //_contact = contact;
            //lblName.Text = contact.Name;
		}
	}
}