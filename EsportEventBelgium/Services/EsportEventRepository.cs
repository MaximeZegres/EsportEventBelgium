using EsportEventBelgium.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportEventBelgium.Services
{
    public class EsportEventRepository : IEsportEventRepository
    {
        private readonly EsportEventContext _context;

        public EsportEventRepository(EsportEventContext context)
        {
            _context = context;
        }


        public IEnumerable<Organization> GetOrganizations()
        {
            return _context.Organizations.OrderBy(o => o.Name);
        }

        public Organization GetOrganization(int id)
        {
            return _context.Organizations.FirstOrDefault(o => o.Id == id);
        }

        public void AddOrganization(Organization organization)
        {
            _context.Organizations.Add(organization);
        }

        public void DeleteOrganization(Organization organization)
        {
            _context.Organizations.Remove(organization);
        }




        public IEnumerable<Event> GetEvents()
        {
            return _context.Events.OrderBy(o => o.BeginDate);
        }

        public Event GetEvent(int id)
        {
            return _context.Events.FirstOrDefault(o => o.Id == id);
        }

        public void AddEvent(Event esportEvent)
        {
            _context.Events.Add(esportEvent);
        }

        public void DeleteEvent(Event esportEvent)
        {
            _context.Events.Remove(esportEvent);
        }




        public IEnumerable<Game> GetGames()
        {
            return _context.Games.OrderBy(g => g.Name);
        }

        public Game GetGame(int id)
        {
            return _context.Games.FirstOrDefault(o => o.Id == id);
        }

        public void AddGame(Game game)
        {
            _context.Games.Add(game);
        }

        public void DeleteGame(Game game)
        {
            _context.Games.Remove(game);
        }


    }
}
