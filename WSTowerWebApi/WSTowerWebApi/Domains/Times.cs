using System;
using System.Collections.Generic;

namespace WSTowerWebApi.Domains
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

        public virtual ICollection<EventoFutebol> EventoFutebolIdTimeCasaNavigation { get; set; }
        public virtual ICollection<EventoFutebol> EventoFutebolIdTimeVisitanteNavigation { get; set; }
    }
}
