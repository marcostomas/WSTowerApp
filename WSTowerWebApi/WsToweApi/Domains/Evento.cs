using System;
using System.Collections.Generic;

namespace WsToweApi.Domains
{
    public partial class Evento
    {
        public Evento()
        {
            Favoritos = new HashSet<Favoritos>();
        }

        public int IdEvento { get; set; }
        public DateTime DataEvento { get; set; }
        public string Descricao { get; set; }
        public DateTime HoraDoEvento { get; set; }
        public int IdEstadio { get; set; }
        public int IdTipoEvento { get; set; }
        public int IdTipoParticipacao { get; set; }
        public int? IdEventoShow { get; set; }
        public int? IdEventoFutebol { get; set; }
        public int? IdEventoESports { get; set; }
        public bool? AcessoLivre { get; set; }

        public Estadio IdEstadioNavigation { get; set; }
        public EventoESports IdEventoESportsNavigation { get; set; }
        public EventoFutebol IdEventoFutebolNavigation { get; set; }
        public EventoShow IdEventoShowNavigation { get; set; }
        public TipoEvento IdTipoEventoNavigation { get; set; }
        public TipoParticipacao IdTipoParticipacaoNavigation { get; set; }
        public ICollection<Favoritos> Favoritos { get; set; }
    }
}
