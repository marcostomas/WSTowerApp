using System;
using System.Collections.Generic;
using System.Text;

namespace WSTowerApp.Models
{
    public class Evento
    {
        public int ID { get; set; }
        public DateTime DataHora { get; set; }
        public string NomeEstadio { get; set; }

        public string NomeTipoEvento { get; set; }
        public string NomeTipoParticipacao { get; set; }

        public string NomeEvento { get; set; }

        public bool AcessoLivre { get; set; }
        public string Favorito { get; set; }
    }
}
