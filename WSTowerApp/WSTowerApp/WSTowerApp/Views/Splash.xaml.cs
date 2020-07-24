using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowerApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Splash : ContentPage
    {
        public Splash()
        {
            InitializeComponent();
            Inicializar();
        }

        private async void Inicializar()
        {
            await Task.Delay(4000);

            App.Current.MainPage = new NavigationPage(new Login());
        }
    }
}