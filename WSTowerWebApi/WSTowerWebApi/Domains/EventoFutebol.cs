using System;
using System.Collections.Generic;

namespace WSTowerWebApi.Domains
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

        public virtual Times IdTimeCasaNavigation { get; set; }
        public virtual Times IdTimeVisitanteNavigation { get; set; }
        public virtual ICollection<Evento> Evento { get; set; }
    }
}
