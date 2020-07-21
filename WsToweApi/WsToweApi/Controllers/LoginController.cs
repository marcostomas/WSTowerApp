using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WsToweApi.Domains;
using WsToweApi.Repositories;
using WsToweApi.ViewModels;

namespace WsToweApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        UsuarioRepository _u { get; set; }

        public LoginController()
        {
            _u = new UsuarioRepository();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel lvm)
        {
            try
            {
                Usuario UsuarioBuscado = _u.Login(lvm);

                if (UsuarioBuscado == null)
                {
                    return BadRequest("Email ou senha incorretos");
                }

                return Ok("Bem vindo:" + UsuarioBuscado.NomeUsuario);
            }
            catch (Exception e)
            {
                return BadRequest("Nao foi possivel logar");
            }
        }
    }
}