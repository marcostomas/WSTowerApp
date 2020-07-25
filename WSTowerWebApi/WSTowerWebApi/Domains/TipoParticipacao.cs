using System;
using System.Collections.Generic;

namespace WSTowerWebApi.Domains
{
    public partial class TipoParticipacao
    {
        public TipoParticipacao()
        {
            Evento = new HashSet<Evento>();
        }

        public int IdTipoParticipacao { get; set; }
        public string TituloParticipacao { get; set; }

        public virtual ICollection<Evento> Evento { get; set; }
    }
}
