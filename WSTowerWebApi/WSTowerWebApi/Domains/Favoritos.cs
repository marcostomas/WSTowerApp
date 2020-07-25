using System;
using System.Collections.Generic;

namespace WSTowerWebApi.Domains
{
    public partial class Favoritos
    {
        public int IdFavoritos { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdEvento { get; set; }
        public bool? StatusFavorito { get; set; }

        public virtual Evento IdEventoNavigation { get; set; }
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
