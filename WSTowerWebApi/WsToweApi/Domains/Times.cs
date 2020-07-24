using System;
using System.Collections.Generic;

namespace WsToweApi.Domains
{
    public partial class Times
    {
        public Times()
        {
            EventoFutebolIdTimeCasaNavigation = new HashSet<EventoFutebol>();
            EventoFutebolIdTimeVisitanteNavigation = new HashSet<EventoFutebol>();
        }

        public int IdTimes { get; set; }
        public string NomeTime { get; set; }

        public ICollection<EventoFutebol> EventoFutebolIdTimeCasaNavigation { get; set; }
        public ICollection<EventoFutebol> EventoFutebolIdTimeVisitanteNavigation { get; set; }
    }
}
