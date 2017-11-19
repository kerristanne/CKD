using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CKD
{
    public partial class DailyMoodCheck : ContentPage
    {
        public DailyMoodCheck()
        {
            InitializeComponent();

            badmood.Clicked += async (sender, args) =>
            {
                // log response in DB
                await Navigation.PushAsync(new MainPage());
                Navigation.RemovePage(this);
            };

            okmood.Clicked += async (sender, args) =>
            {
                // log response in DB
                await Navigation.PushAsync(new MainPage());
                Navigation.RemovePage(this);
            };

            goodmood.Clicked += async (sender, args) =>
            {
                // log response in DB
                await Navigation.PushAsync(new MainPage());
                Navigation.RemovePage(this);
            };
        }
    }
}
