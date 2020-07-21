using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WsToweApi.Domains;

namespace WsToweApi.Interfaces
{
    interface IEventoRepository
    {
        List<Evento> ListarEvento();
    }
}
