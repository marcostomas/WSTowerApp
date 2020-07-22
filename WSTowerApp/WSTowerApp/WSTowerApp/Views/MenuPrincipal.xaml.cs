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
    public partial class MenuPrincipal : ContentPage
    {
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

        private void  OnClicked_Sair(object sender, EventArgs e)
        {
            //Terminar depois
            DisplayActionSheet("Atenção","Cancelar","Ok","Você deseja sair?");
            App.MasterDetail.Detail.Navigation.PopAsync();
        }
    }
}