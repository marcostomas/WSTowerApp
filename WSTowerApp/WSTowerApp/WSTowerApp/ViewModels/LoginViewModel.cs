using System;
using System.Collections.Generic;
using System.Text;
using WSTowerApp.Models;

namespace WSTowerApp.ViewModels
{
    class LoginViewModel
    {
        public static List<Usuario> UsuarioLogado = new List<Usuario>();

        public static List<Usuario> usuarios = new List<Usuario>();

        public static int Contador = 1;

        public LoginViewModel()
        {
            Usuario usuario = new Usuario()
            {
                Email = "Douglas@g",
                Senha = "123123",
                Telefone = "12345678"
            };
            usuarios.Add(usuario);
        }

        public bool Cadastrar(Usuario usuario)
        {
            if (usuario.Email == null || usuario.Senha == null || usuario.Nome == null || usuario.Telefone == null)
            {
                return false;
            }
            usuario.id = Contador;
            usuarios.Add(usuario);
            Contador++;

            return true;
        }

        public Usuario Login(string email, string senha)
        {
            Usuario usuarioBuscado = usuarios.Find(u => u.Email == email && u.Senha == senha);

            if (usuarioBuscado == null)
            {
                return null;
            }
            else
            {
                UsuarioLogado.Add(usuarioBuscado);

                return usuarioBuscado;
            }
        }

        public Usuario Perfil()
        {
            return UsuarioLogado[0];
        }

        public bool Deletar(bool Deletou)
        {
            try
            {


                Usuario usuarioDeletado = UsuarioLogado[0];

                Usuario userCadastrado = usuarios.Find(u => u == usuarioDeletado);

                usuarios.Remove(userCadastrado);

                UsuarioLogado.Remove(usuarioDeletado);

                return true;

            }
            catch (Exception e)
            {
                return false;

            }
        }
        public bool Atualizar(Usuario UsuariAtualizado)
        {
            try
            {
                Usuario usuarioBuscado = usuarios.Find(u => u == UsuarioLogado[0]);

                if (UsuariAtualizado.Email != null)
                {
                    UsuarioLogado[0].Email = UsuariAtualizado.Email;

                    usuarioBuscado.Email = UsuariAtualizado.Email;
                }

                if (UsuariAtualizado.Nome != null)
                {
                    UsuarioLogado[0].Nome = UsuariAtualizado.Nome;

                    usuarioBuscado.Nome = UsuariAtualizado.Nome;
                }

                if (UsuariAtualizado.Telefone != null)
                {
                    UsuarioLogado[0].Telefone = UsuariAtualizado.Telefone;

                    usuarioBuscado.Telefone = UsuariAtualizado.Telefone;
                }

                if (UsuariAtualizado.Telefone != null)
                {
                    UsuarioLogado[0].Senha = UsuariAtualizado.Senha;

                    usuarioBuscado.Senha = UsuariAtualizado.Senha;
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
