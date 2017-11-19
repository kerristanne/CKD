using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CKD.Introduction
{
    public partial class LoginOrRegister : ContentPage
    {
        public LoginOrRegister()
        {
            InitializeComponent();

            login.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Introduction.DailyMoodCheck());
                Navigation.RemovePage(this);
            };

            register.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Introduction.RegisterPage());
                Navigation.RemovePage(this);
            };
        }
    }
}
