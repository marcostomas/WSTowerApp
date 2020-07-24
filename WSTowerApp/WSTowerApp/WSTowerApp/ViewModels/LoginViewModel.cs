using System;
using System.Collections.Generic;
using System.Text;
using WSTowerApp.Models;

namespace WSTowerApp.ViewModels
{
    class LoginViewModel
    {
        public List<Usuario> LogSESSEION { get; set; }

        public static List<Usuario> UsuarioLogado = new List<Usuario>();

        public static List<Usuario> usuarios = new List<Usuario>();

        public static int Contador = 1;

        public LoginViewModel()
        {
            Perfil();
            BuscarUsuarioLogado();
            ControlarSesseion();
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

                Perfil();

                return usuarioBuscado;
            }
        }

        public List<Usuario> Perfil()
        {
            try
            {
                LogSESSEION = new List<Usuario>
               {
                new Usuario
                {
                  Email=UsuarioLogado[0].Email,
                  Senha=UsuarioLogado[0].Senha,
                 Telefone=UsuarioLogado[0].Telefone,
                  Nome=UsuarioLogado[0].Nome
               }
            };

                return LogSESSEION;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool Deletar(bool Deletou)
        {
            try
            {
                Usuario usuarioDeletado = UsuarioLogado[0];

                Usuario userCadastrado = usuarios.Find(u => u == usuarioDeletado);

                usuarios.Remove(userCadastrado);

                RemoveSESSION();

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

                    LogSESSEION[0].Email = UsuariAtualizado.Email;
                }

                if (UsuariAtualizado.Nome != null)
                {
                    UsuarioLogado[0].Nome = UsuariAtualizado.Nome;

                    usuarioBuscado.Nome = UsuariAtualizado.Nome;

                    LogSESSEION[0].Nome = UsuariAtualizado.Nome;
                }

                if (UsuariAtualizado.Telefone != null)
                {
                    UsuarioLogado[0].Telefone = UsuariAtualizado.Telefone;

                    usuarioBuscado.Telefone = UsuariAtualizado.Telefone;

                    LogSESSEION[0].Telefone = UsuariAtualizado.Telefone;
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public List<Usuario> BuscarUsuarioLogado()
        {
            try
            {
                if (LogSESSEION[0] != null)
                {
                    return LogSESSEION;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Usuario BuscarUsuarioLogadoDeletar()
        {
            try
            {
                Usuario usuarioBuscado = usuarios.Find(u => u == UsuarioLogado[0]);

                if (usuarioBuscado == null)
                {
                    return null;
                }
                else
                {
                    return usuarioBuscado;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool ControlarSesseion()
        {
            try
            {
                LogSESSEION.RemoveAt(1);

                UsuarioLogado.RemoveAt(1);

                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void RemoveSESSION()
        {
            LogSESSEION.Clear();

            UsuarioLogado.Clear();
        }
    }
}
