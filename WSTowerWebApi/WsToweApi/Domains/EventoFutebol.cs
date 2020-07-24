using System;
using System.Collections.Generic;

namespace WsToweApi.Domains
{
    public partial class EventoFutebol
    {
        public EventoFutebol()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdEventoFutebol { get; set; }
        public int IdTimeCasa { get; set; }
        public int IdTimeVisitante { get; set; }

        public Times IdTimeCasaNavigation { get; set; }
        public Times IdTimeVisitanteNavigation { get; set; }
        public ICollection<Evento> Evento { get; set; }
    }
}
