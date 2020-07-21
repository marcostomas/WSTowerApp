using System;
using System.Collections.Generic;

namespace WsToweApi.Domains
{
    public partial class EventoShow
    {
        public EventoShow()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdEventoShow { get; set; }
        public string NomeEventoShow { get; set; }

        public ICollection<Evento> Evento { get; set; }
    }
}
