using System;
using System.Collections.Generic;

namespace WSTowerWebApi.Domains
{
    public partial class EventoESports
    {
        public EventoESports()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdEventoESports { get; set; }
        public string NomeEventoESports { get; set; }

        public virtual ICollection<Evento> Evento { get; set; }
    }
}
