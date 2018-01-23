using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CKD.Introduction
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
		    InitializeComponent ();
          
            LoginButton.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new Introduction.DailyMoodCheck());
                Navigation.RemovePage(this);
            };

        }
	}
}