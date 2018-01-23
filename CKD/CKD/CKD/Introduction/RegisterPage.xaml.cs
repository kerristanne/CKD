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

            RegisterButton.Clicked += async (sender, args) =>
            {
                User newUser = new User()
                {
                    Name = NameEntry.Text,
                    Email = EmailEntry.Text,
                    Phone = PhoneEntry.Text,
                    Age = AgeEntry.Text,
                    Weight = WeightEntry.Text,
                    ActivityLevel = ActivityLevelEntry.Text
                };

                await Navigation.PushAsync(new Introduction.DailyMoodCheck());
                Navigation.RemovePage(this);
            };
        }

      /*  async void CreateAccount(object sender, System.EventArgs e)
        {
            // send information to DB
            // verify phone number
            // demographics page instead of dailymoodcheck
            // register account => demographics => dailymoodcheck => rest of app
            await Navigation.PushAsync(new Introduction.DailyMoodCheck());
            Navigation.RemovePage(this);
        }*/
    }
}
