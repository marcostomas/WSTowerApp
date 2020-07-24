using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
                App.Current.MainPage = new MasterMenu();
            }
            else
            {
                DisplayAlert("", "Email ou senha incorretos","Fechar");
            }        
            
        }

        private async void OnClicked_Cadastrar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Cadastro());
        }
    }
}