using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace CKD
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            // This is where we set what the first page we go to is
            // MainPage = new NavigationPage(new CKD.DailyMoodCheck());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts

            // check to see if logged in. If so, go to daily mood check.
            // If not go here
            MainPage = new NavigationPage(new CKD.Introduction.LoginOrRegister());
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
            // MainPage = new NavigationPage(new CKD.DailyMoodCheck());
		}
	}
}
