using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSTowerApp.Models;
using WSTowerApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowerApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        LoginViewModel lvm = new LoginViewModel();

        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void OnClicked_Entrar(object sender, EventArgs e)
        {
            LoginClass login = new LoginClass();

            login.Email = lbEmail.Text;

            login.Senha = lbSenha.Text;

            Usuario usuarioBuscado = lvm.Login(login.Email, login.Senha);

            if (usuarioBuscado != null)
            {
                Navigation.PushAsync(new Principal());
            }
            else
            {
                MessagingCenter.Send<String>("Erro no login", "Sucesso");
            }
        }
        private void OnClicked_Cadastrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Cadastro());
        }
    }
}