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
    public partial class Alterar : ContentPage
    {
        LoginViewModel lvm = new LoginViewModel();
        public Alterar()
        {
            InitializeComponent();
        }

        async void OnClicked_Editar(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = new Usuario();

                usuario.Email = lbEmail.Text;
                usuario.Nome = lbNome.Text;
                usuario.Telefone = lbTelefone.Text;

                if (lvm.BuscarCadastro(usuario))
                {
                    if (lvm.Atualizar(usuario))
                    {
                        await DisplayAlert("", "Usuario atualizado com sucesso.Os campos preenchidos com menos de 4 caracteres não foram alterados", "Fechar");
                        lvm.RemoveSESSION();
                        await Navigation.PushAsync(new Login());
                    }
                    else
                    {
                        await DisplayAlert("", "Nao foi possivel atualizar", "Fechar");
                    }
                }
                else
                {
                    await DisplayAlert("", "Esse email ja foi cadastrado", "Fechar");
                } 
            }
            catch (Exception ex)
            {
                await DisplayAlert("", "Erro no sistema", "Fechar");
            }
        }
    }
}