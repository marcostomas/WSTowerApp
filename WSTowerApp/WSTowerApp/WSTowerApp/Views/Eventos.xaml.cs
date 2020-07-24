using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSTowerApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WSTowerApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Eventos : ContentPage
    {
        public static IList<Evento> EventosFavoritos { get; private set; }

        public Eventos()
        {
            InitializeComponent();

            EventosFavoritos = new List<Evento>();
            //NavigationPage.SetHasNavigationBar(this, false);

            EventosFavoritos.Add(new Evento
            {
                ID = 2,
                DataHora = Convert.ToDateTime("21/07/2020 21:00"),
                Favorito = "Favorito",
                NomeEvento = "Corinthians X Palmeiras",
                NomeEstadio = "Alianz Parque | São Paulo - Barra Funda",
                NomeTipoParticipacao = "Transmissão Ao Vivo",
                NomeTipoEvento = "Futebol",
                AcessoLivre = true
            });

            EventosFavoritos.Add(new Evento
            {
                ID = 4,
                DataHora = Convert.ToDateTime("21/07/2020 20:30"),
                Favorito = "Favorito",
                NomeEvento = "Santos X São Paulo",
                NomeEstadio = "Estádio Urbano Caldeira | Santos - Vila Belmiro",
                NomeTipoParticipacao = "Transmissão Ao Vivo",
                NomeTipoEvento = "Futebol",
                AcessoLivre = true
            });

            EventosFavoritos.Add(new Evento
            {
                ID = 6,
                DataHora = Convert.ToDateTime("22/07/2020 11:00"),
                Favorito = "Favorito",
                NomeEvento = "Feira de Artesanato",
                NomeEstadio = "Jockey CLub | São Paulo - Cidade Jardim",
                NomeTipoParticipacao = "Para Participar",
                NomeTipoEvento = "Feira",
                AcessoLivre = true
            });

            EventosFavoritos.Add(new Evento
            {
                ID = 7,
                DataHora = Convert.ToDateTime("24/07/2020 16:00"),
                Favorito = "Favorito",
                NomeEvento = "Feira de Artesanato Alternativa",
                NomeEstadio = "Estádio Caiu na Vila o Peixe Fuzila | Santos - Vila Belmiro",
                NomeTipoParticipacao = "Para Participar",
                NomeTipoEvento = "Feira",
                AcessoLivre = true
            });

            EventosFavoritos.Add(new Evento
            {
                ID = 8,
                DataHora = Convert.ToDateTime("25/07/2020 23:00"),
                Favorito = "Favorito",
                NomeEvento = "Ed Sheeran - Turnê",
                NomeEstadio = "Estádio Governador Magalhães Pinto (Mineirão) | Belo Horizonte - São José",
                NomeTipoParticipacao = "Para Assistir no Local",
                NomeTipoEvento = "Música",
                AcessoLivre = true
            });

            EventosLista.ItemsSource = EventosFavoritos;
        }
    }
}