using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CKD
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        async void CreateAccount(object sender, System.EventArgs e)
        {
            // send information to DB
            // verify phone number
            // demographics page instead of dailymoodcheck
            // register account => demographics => dailymoodcheck => rest of app
            await Navigation.PushAsync(new DailyMoodCheck());
            Navigation.RemovePage(this);
        }

        async void Login(object sender, System.EventArgs e)
        {
            // take user to login page instead
            // from there go to daily mood check
            await Navigation.PushAsync(new DailyMoodCheck());
            Navigation.RemovePage(this);
        }
    }
}
