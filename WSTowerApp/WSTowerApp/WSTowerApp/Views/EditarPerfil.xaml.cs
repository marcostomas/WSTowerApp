﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowerApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditarPerfil : ContentPage
    {
        public EditarPerfil()
        {
            InitializeComponent();

        }

        async void OnClicekd_Alterar(object sender, EventArgs e)
        {
            await DisplayAlert("Sucesso","Dados alterados com sucesso","Ok");
            await Navigation.PopAsync();

        }
    }
}