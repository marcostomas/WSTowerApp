using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WsToweApi.Domains;
using WsToweApi.Repositories;

namespace WsToweApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        UsuarioRepository _u { get; set; }

        public UsuariosController()
        {
            _u = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult ListarUsuarios()
        {
            return Ok(_u.ListarUsuario());
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _u.Deletar(id);

            return Ok("Usuario Deletado");
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Usuario usuario)
        {
            try
            {
                // Faz a chamada para o método e armazena em um objeto usuarioBuscado
                Usuario usuarioBuscado = _u.BuscarPorid(id);

                // Verifica se o usuário foi encontrado
                if (usuarioBuscado != null)
                {
                    // Faz a chamada para o método
                    _u.Atualizar(id, usuario);

                    // Retora a resposta da requisição 204 - No Content
                    return Ok("Usuario atualizado");
                }

                // Retorna a resposta da requisição 404 - Not Found com uma mensagem
                return NotFound("Nenhum usuário encontrado para o ID informado");
            }
            catch (Exception error)
            {
                // Retorna a resposta da requisição 400 - Bad Request e o erro ocorrido
                return BadRequest(error);
            }
        }
    }
}