using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CKD.Introduction
{
    public partial class DailyMoodCheck : ContentPage
    {
        public DailyMoodCheck()
        {
            InitializeComponent();

            sadmood.Clicked += async (sender, args) =>
            {
                // log response in DB
                await Navigation.PushAsync(new MainPage());
                Navigation.RemovePage(this);
            };

            happymood.Clicked += async (sender, args) =>
            {
                // log response in DB
                await Navigation.PushAsync(new MainPage());
                Navigation.RemovePage(this);
            };

            angrymood.Clicked += async (sender, args) =>
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
