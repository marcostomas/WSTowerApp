using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSTowerApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowerApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        LoginViewModel lvm = new LoginViewModel();
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private async void OnClicked_Sobre(object sender, EventArgs e)
        {
            await App.NavigationMasterDetail(new Sobre());
        }

        private async void OnClicked_Perfil(object sender, EventArgs e)
        {
            await App.NavigationMasterDetail(new Perfil());
        }

        private async void OnClicked_MeusEventos(object sender, EventArgs e)
        {
            await App.NavigationMasterDetail(new Eventos());
        }

        private async void OnClicked_Sair(object sender, EventArgs e)
        {
            string result = await DisplayActionSheet("Atenção", "Cancelar", "Ok", "Você deseja sair?");

            if (result == "Ok")
            {
                lvm.RemoveSESSION();
                App.Current.MainPage = new NavigationPage(new Login());
            }
        }
    }
}