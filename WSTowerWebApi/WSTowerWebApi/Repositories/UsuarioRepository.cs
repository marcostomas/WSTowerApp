using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTowerWebApi.Contexts;
using WSTowerWebApi.Domains;
using WSTowerWebApi.Interfaces;
using WSTowerWebApi.ViewModels;

namespace WSTowerWebApi.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Atualizar(int id, Usuario usuario)
        {
            using (WSTowerContext ctx = new WSTowerContext())
            {
                Usuario usuarioBuscado = ctx.Usuario.Find(id);

                if (usuario.NomeUsuario != null)
                {
                    usuarioBuscado.NomeUsuario = usuario.NomeUsuario;
                }

                if (usuario.Email != null)
                {
                    usuarioBuscado.Email = usuario.Email;
                }

                if (usuario.Senha != null)
                {
                    usuarioBuscado.Senha = usuario.Senha;
                }

                if (usuario.Telefone != null)
                {
                    usuarioBuscado.Telefone = usuario.Telefone;
                }

                if (usuario.Foto != null)
                {
                    usuarioBuscado.Foto = usuario.Foto;
                }

                ctx.Update(usuarioBuscado);

                ctx.SaveChanges();
            }
        }

        public bool BuscarPorEmail(string email)
        {
            using (WSTowerContext ctx = new WSTowerContext())
            {
                try
                {
                    Usuario usuario = ctx.Usuario.FirstOrDefault(u => u.Email == email);

                    if (usuario == null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public Usuario BuscarPorid(int id)
        {
            using (WSTowerContext ctx = new WSTowerContext())
            {
                try
                {
                    Usuario usuarioBuscado = ctx.Usuario.Find(id);

                    return usuarioBuscado;

                }
                catch (Exception e)
                {
                    return null;
                }

            }

        }

        public bool Cadastrar(string nome, string email, string senha, string telefone)
        {
            using (WSTowerContext ctx = new WSTowerContext())
            {
                try
                {
                    Usuario usuarioNovo = new Usuario()
                    {
                        NomeUsuario = nome,
                        Email = email,
                        Senha = senha,
                        Telefone = telefone,
                        IdTipoUsuario = 2
                    };

                    ctx.Add(usuarioNovo);

                    ctx.SaveChanges();

                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }
        }

        public void Deletar(int id)
        {
            using (WSTowerContext ctx = new WSTowerContext())
            {

                Usuario usuarioBuscado = ctx.Usuario.Find(id);

                ctx.Remove(usuarioBuscado);

                ctx.SaveChanges();
            }

        }

        public List<Usuario> ListarUsuario()
        {
            using (WSTowerContext ctx = new WSTowerContext())
            {
                return ctx.Usuario.ToList();
            }
        }

        public Usuario Login(LoginViewModel Usuario)
        {
            using (WSTowerContext ctx = new WSTowerContext())
            {
                try
                {
                    Usuario usuarioAchado = ctx.Usuario.FirstOrDefault(U => U.Email == Usuario.Email && U.Senha == Usuario.Senha);

                    if (usuarioAchado == null)
                    {
                        return null;
                    }
                    return usuarioAchado;

                }
                catch (Exception e)
                {
                    return null;
                }

            }
        }
    }
}
