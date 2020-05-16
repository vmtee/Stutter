using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Stutter
{
    public partial class LoginPage : ContentPage
    {
       
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MyTabbedPage());
        }
    }
}
