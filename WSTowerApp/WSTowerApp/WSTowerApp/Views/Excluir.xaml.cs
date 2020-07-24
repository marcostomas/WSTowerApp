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
    public partial class Excluir : ContentPage
    {   
        LoginViewModel lvm = new LoginViewModel();
     
        public Excluir()
        {
            InitializeComponent();
        }

         private void OnClicked_Deletar(object sender, EventArgs e)
        {
            bool Click = true;

            try
            {
                Usuario usuarioLogado = lvm.BuscarUsuarioLogadoDeletar();
               
                if (usuarioLogado == null)
                {
                    DisplayAlert("", "Usuario logado nao encontrado", "Fechar");
                }
                else
                {
                    lvm.Deletar(Click);
                    DisplayAlert("", "Usuario Deletado", "Fechar");

                    Navigation.PushAsync(new LoginPage());
                }
            }catch(Exception ex)
            {
                DisplayAlert("", "Erro no sistema", "Fechar");
            }          
        }
    }
}