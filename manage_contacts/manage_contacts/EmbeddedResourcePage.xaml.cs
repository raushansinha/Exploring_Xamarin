﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace manage_contacts
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EmbeddedResourcePage : ContentPage
	{
		public EmbeddedResourcePage ()
		{
			InitializeComponent ();
		}
	}
}