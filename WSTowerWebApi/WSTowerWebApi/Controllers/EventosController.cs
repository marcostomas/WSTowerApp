using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WSTowerWebApi.Repositories;

namespace WSTowerWebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        EventoRepository _u { get; set; }

        public EventosController()
        {
            _u = new EventoRepository();
        }

        [HttpGet]
        public IActionResult ListarEventos()
        {
            return Ok(_u.ListarEvento());
        }
    }
}