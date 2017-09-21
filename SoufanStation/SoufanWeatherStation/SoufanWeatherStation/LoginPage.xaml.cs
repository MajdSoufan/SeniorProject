using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SoufanWeatherStation
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

		void Handle_Clicked(object sender, System.EventArgs e)
		{
            DisplayAlert("Title","Sameer","OK");
		}
    }
}
