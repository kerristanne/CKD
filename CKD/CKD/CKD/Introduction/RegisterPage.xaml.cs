using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CKD.Introduction
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
            await Navigation.PushAsync(new Introduction.DailyMoodCheck());
            Navigation.RemovePage(this);
        }
    }
}
