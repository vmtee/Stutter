using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Stutter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ///MainPage = new LoginPage();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
