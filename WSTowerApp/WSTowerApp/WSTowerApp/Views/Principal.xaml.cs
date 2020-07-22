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
    public partial class Principal : ContentPage
    {
        public IList<Evento> Eventos { get; private set; }
        
        public Principal()
        {
            InitializeComponent();

            Eventos = new List<Evento>();

            Eventos.Add(new Evento
            {
               ID = 1,
               NomeEstadio = "Estádio Cícero Pompeu de Toledo | São Paulo - Morumbi",
               NomeTipoEvento = "Futebol",
               NomeTipoParticipacao = "Transmissão Ao Vivo",
               NomeEvento = "Ponte Preta X Grêmio Novorizontino (portões fechados)",
               AcessoLivre = true,
               Favorito = false
            });

            Eventos.Add(new Evento
            {
                ID = 2,
                NomeEstadio = "Alianz Parque | São Paulo - Barra Funda",
                NomeTipoEvento = "Futebol",
                NomeTipoParticipacao = "Transmissão Ao Vivo",
                NomeEvento = "Corinthians X Palmeiras",
                AcessoLivre = true,
                Favorito = true
            });

            Eventos.Add(new Evento
            {
                ID = 3,
                NomeEstadio = "Estádio Jornalista Mário Filho | Rio de Janeiro - Maracanã",
                NomeTipoEvento = "Futebol",
                NomeTipoParticipacao = "Para Assistir No Local",
                NomeEvento = "Flamengo X Fluminense",
                AcessoLivre = true,
                Favorito = false
            });

            Eventos.Add(new Evento
            {
                ID = 4,
                NomeEstadio = "Estádio Urbano Caldeira | Santos - Vila Belmiro",
                NomeTipoEvento = "Futebol",
                NomeTipoParticipacao = "Transmissão Ao Vivo",
                NomeEvento = "Santos X São Paulo",
                AcessoLivre = true,
                Favorito = true
            }); 
            
            Eventos.Add(new Evento
            {
                ID = 5,
                NomeEstadio = "Arena Corinthians | São Paulo - Itaquera",
                NomeTipoEvento = "E-Sports",
                NomeTipoParticipacao = "Para Assistir No Local",
                NomeEvento = "Campeonato Brasileiro de League of Legends",
                AcessoLivre = true,
                Favorito = false
            }); 
            
            Eventos.Add(new Evento
            {
                ID = 6,
                NomeEstadio = "Jockey CLub | São Paulo - Cidade Jardim",
                NomeTipoEvento = "Feira",
                NomeTipoParticipacao = "Para Participar",
                NomeEvento = "Feira de Artesanato",
                AcessoLivre = true,
                Favorito = true  
            }); 
            
            Eventos.Add(new Evento
            {
                ID = 7,
                NomeEstadio = "Estádio Cícero Pompeu de Toledo | São Paulo - Morumbi",
                NomeTipoEvento = "Música",
                NomeTipoParticipacao = "Para Assistir no Local",
                NomeEvento = "120 Anos de Mamonas Assasinas",
                AcessoLivre = true,
                Favorito = true
            });
        }

        private void buscarEventos_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

    }
}