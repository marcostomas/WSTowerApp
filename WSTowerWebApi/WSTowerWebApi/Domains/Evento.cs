using System;
using System.Collections.Generic;

namespace WSTowerWebApi.Domains
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

        public virtual Estadio IdEstadioNavigation { get; set; }
        public virtual EventoESports IdEventoESportsNavigation { get; set; }
        public virtual EventoFutebol IdEventoFutebolNavigation { get; set; }
        public virtual EventoShow IdEventoShowNavigation { get; set; }
        public virtual TipoEvento IdTipoEventoNavigation { get; set; }
        public virtual TipoParticipacao IdTipoParticipacaoNavigation { get; set; }
        public virtual ICollection<Favoritos> Favoritos { get; set; }
    }
}
