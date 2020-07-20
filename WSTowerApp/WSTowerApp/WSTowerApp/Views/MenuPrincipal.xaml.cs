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
    public partial class MenuPrincipal : MasterDetailPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            Detail = new NavigationPage(new Principal());
            IsPresented = false;
        }

        private void OnClicked_MeusEventos(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Eventos());
            IsPresented = false;
        }

        private void OnClicked_Sobre(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Sobre());
            IsPresented = false;
        }

        private void OnClicked_Perfil(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new Perfil());
            IsPresented = false;
        }
    }
}