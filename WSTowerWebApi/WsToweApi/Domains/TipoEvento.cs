using System;
using System.Collections.Generic;

namespace WsToweApi.Domains
{
    public partial class TipoEvento
    {
        public TipoEvento()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdTipoEvento { get; set; }
        public string NomeTipoEvento { get; set; }

        public ICollection<Evento> Evento { get; set; }
    }
}
