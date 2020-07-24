using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WsToweApi.Domains;
using WsToweApi.Interfaces;

namespace WsToweApi.Repositories
{
    public class EventoRepository : IEventoRepository
    {
        public List<Evento> ListarEvento()
        {
            using (WSTowerContext ctx = new WSTowerContext())
            {
                return ctx.Evento.Include(u => u.IdEstadioNavigation).Include(u => u.IdTipoEventoNavigation)
                 .Include(u => u.IdTipoParticipacaoNavigation)
                 .Include(u => u.IdEventoFutebolNavigation).Include(u => u.IdEventoShowNavigation)
                 .Include(u => u.IdEventoESportsNavigation).Include(u => u.Favoritos).ToList();
            }
        }
    }
}
