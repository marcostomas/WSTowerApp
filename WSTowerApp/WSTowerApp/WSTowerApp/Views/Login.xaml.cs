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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void OnClicked_Entrar(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new MenuPrincipal());
        }

        private void OnClicked_Cadastrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastro());
        }
    }
}