using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace manage_contacts
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new GreetPage();
            //MainPage = new DataBinding();
            //MainPage = new DeviceDifference();
            //MainPage = new StackPage();
            //MainPage = new GridPage();
            //MainPage = new AbsolutePage();
            //MainPage = new RelativePage();
            //MainPage = new ImagePage();
            //MainPage = new EmbeddedResourcePage();
            //MainPage = new ListPage();
            //MainPage = new RefreshListPage();
            //MainPage = new WelcomePage();
            //MainPage = new NavigationPage(new WelcomePage())
            //{
            //    BarBackgroundColor = Color.Gray,
            //    BarTextColor = Color.White
            //};

            //MainPage = new NavigationPage(new ContactPage())
            //{
            //    BarBackgroundColor = Color.Gray,
            //    BarTextColor = Color.White
            //};

            MainPage = new ContactMasterDetailPage();
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
