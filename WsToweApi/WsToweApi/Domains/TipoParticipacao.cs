using System;
using System.Collections.Generic;

namespace WsToweApi.Domains
{
    public partial class TipoParticipacao
    {
        public TipoParticipacao()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdTipoParticipacao { get; set; }
        public string TituloParticipacao { get; set; }

        public ICollection<Evento> Evento { get; set; }
    }
}
