using System;
using System.Collections.Generic;

namespace WsToweApi.Domains
{
    public partial class EventoESports
    {
        public EventoESports()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdEventoESports { get; set; }
        public string NomeEventoESports { get; set; }

        public ICollection<Evento> Evento { get; set; }
    }
}
