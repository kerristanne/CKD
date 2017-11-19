using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CKD
{
	public partial class MainPage : ContentPage
    {
        public MainPage()
		{
			InitializeComponent();
		}

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Login Attempt", "You're logged in!", "OK");
        }
	}
}
