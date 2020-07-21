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
    public partial class CadastroOK : ContentPage
    {
        public CadastroOK()
        {
            InitializeComponent();
        }

        //Colocar o Método com o Pop Async()

        private async void VoltarPaginaAnterior (object sender, EventArgs e)
        {
            
        }
    } 
}