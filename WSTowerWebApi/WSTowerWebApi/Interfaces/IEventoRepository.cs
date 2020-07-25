using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSTowerWebApi.Domains;

namespace WSTowerWebApi.Interfaces
{
    interface IEventoRepository
    {
        List<Evento> ListarEvento();
    }
}
