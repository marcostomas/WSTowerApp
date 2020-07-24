using System;
using System.Collections.Generic;

namespace WsToweApi.Domains
{
    public partial class Estadio
    {
        public Estadio()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdEstadio { get; set; }
        public string NomeEstadio { get; set; }
        public string Endereco { get; set; }

        public ICollection<Evento> Evento { get; set; }
    }
}
