using System;
using System.Collections.Generic;

namespace WSTowerWebApi.Domains
{
    public partial class EventoShow
    {
        public EventoShow()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdEventoShow { get; set; }
        public string NomeEventoShow { get; set; }

        public virtual ICollection<Evento> Evento { get; set; }
    }
}
