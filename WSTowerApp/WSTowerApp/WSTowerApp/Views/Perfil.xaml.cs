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
    public partial class Perfil : ContentPage
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private async void OnClicked_MeusEventosPerfil(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
            await App.NavigationMasterDetail(new Eventos());
        }

        async void OnClicked_EditarPerfil(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EditarPerfil());
        }
    }
}