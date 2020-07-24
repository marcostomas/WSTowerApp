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
    public partial class Cadastro : ContentPage
    { 
 LoginViewModel lvm = new LoginViewModel(); 
        public Cadastro()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void OnClicked_CadastroRealizado(object sender, EventArgs e)
        { 
             Usuario usuarioNovo = new Usuario();

            usuarioNovo.Nome = lbNome.Text;

            usuarioNovo.Email = lbEmail.Text;

            usuarioNovo.Senha = lbSenha.Text;

            usuarioNovo.Telefone = lbTelefone.Text;

            if (lvm.Cadastrar(usuarioNovo))
            {
               DisplayAlert("Sucesso", "Dados cadastrados com sucesso", "Ok");
            Navigation.RemovePage(this);
            }
            else
            {
                DisplayAlert("", "Nao foi possivel efetuar o cadastro", "Fechar");
            }           
        }
    }
}