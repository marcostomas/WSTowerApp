using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WsToweApi.Domains;
using WsToweApi.ViewModels;

namespace WsToweApi.Interfaces
{
    interface IUsuarioRepository
    {
        void Deletar(int id);

        List<Usuario> ListarUsuario();

        Usuario Login(LoginViewModel Usuario);

        bool Cadastrar(string nome, string email, string senha, string telefone);

        bool BuscarPorEmail(String email);

        void Atualizar(int id, Usuario usuario);

        Usuario BuscarPorid(int id);
    }
}
