using System;
using System.Collections.Generic;

namespace WsToweApi.Domains
{
    public partial class Favoritos
    {
        public int IdFavoritos { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdEvento { get; set; }
        public bool? StatusFavorito { get; set; }

        public Evento IdEventoNavigation { get; set; }
        public Usuario IdUsuarioNavigation { get; set; }
    }
}
