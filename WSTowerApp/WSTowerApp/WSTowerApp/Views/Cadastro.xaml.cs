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
            try
            {
                Navigation.RemovePage(this);

                Usuario usuarioNovo = new Usuario();

                usuarioNovo.Nome = lbNome.Text;

                usuarioNovo.Email = lbEmail.Text;

                usuarioNovo.Senha = lbSenha.Text;

                usuarioNovo.Telefone = lbCelular.Text;

                if (lvm.Cadastrar(usuarioNovo))
                {
                    MessagingCenter.Send<String>("Cadastro foi um Sucesso", "Sucesso");
                }
                else
                {
                    MessagingCenter.Send<String>("Erro no Cadastro tente novamente", "ErroCadastro");
                }

            }
            catch (Exception ex)
            {
                MessagingCenter.Send<String>("Erro No sistema", "Erro");
            }

        }
    }
}
