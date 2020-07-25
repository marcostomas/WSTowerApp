using System;
using System.Collections.Generic;

namespace WSTowerWebApi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Favoritos = new HashSet<Favoritos>();
        }

        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public byte[] Foto { get; set; }
        public int IdTipoUsuario { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Favoritos> Favoritos { get; set; }
    }
}
