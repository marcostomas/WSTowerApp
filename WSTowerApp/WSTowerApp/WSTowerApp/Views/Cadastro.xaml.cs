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

        async void OnClicked_CadastroRealizado(object sender, EventArgs e)
        {
            try
            {

                Usuario usuarioNovo = new Usuario();

                usuarioNovo.Nome = lbNome.Text;

                usuarioNovo.Email = lbEmail.Text;

                usuarioNovo.Senha = lbSenha.Text;

                usuarioNovo.Telefone = lbCelular.Text;

                if (usuarioNovo.Email.Length < 4)
                {
                    await DisplayAlert("", "O campo Email deve conter no minimo 4 caracteres", "Fechar");
                }
                if (usuarioNovo.Nome.Length < 4)
                {
                    await DisplayAlert(""," O campo Nome deve conter no minimo 4 caracteres", "Fechar");
                }
                if (usuarioNovo.Senha.Length < 4)
                {
                    await DisplayAlert("", "O campo Senha deve conter no minimo 4 caracteres", "Fechar");
                }
                if (usuarioNovo.Telefone.Length < 4)
                {
                    await DisplayAlert("", "O campo Telefone deve conter no minimo 4 caracteres", "Fechar");
                }

                if (lvm.BuscarCadastro(usuarioNovo))
                {
                    if (lvm.Cadastrar(usuarioNovo))
                    {
                        await DisplayAlert("", "O cadastro foi um sucesso", "Fechar");
                        Navigation.RemovePage(this);
                    }
                    else
                    {
                        await DisplayAlert("", "Preencha todos os campos", "Fechar");
                    }
                }
                else
                {
                    await DisplayAlert("", "Esse email ja foi cadastardo", "Fechar");
                }       
            }
            catch (Exception ex)
            {
                await DisplayAlert("", "preencha todos os campos", "Fechar");
            }
        }
    }
}
