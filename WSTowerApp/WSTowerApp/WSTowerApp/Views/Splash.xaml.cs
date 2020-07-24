using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowerApp.Views
{
    [DesignTimeVisible(false)]
    public partial class Splash : ContentPage
    {
        public Splash()
        {
            InitializeComponent();
            Inicializar();
        }

        private async void Inicializar()
        {
            await this.ScaleTo(0.1, 5000, Easing.BounceIn);
            await this.ScaleTo(2, 1000, Easing.BounceOut);
            App.Current.MainPage = new NavigationPage(new Login());
        }
    }
}