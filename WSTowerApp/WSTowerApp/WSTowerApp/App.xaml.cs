using System;
using WSTowerApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowerApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Splash();
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
