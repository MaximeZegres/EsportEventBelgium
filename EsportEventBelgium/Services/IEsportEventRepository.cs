using EsportEventBelgium.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportEventBelgium.Services
{
    public interface IEsportEventRepository
    {
        // Organization
        IEnumerable<Organization> GetOrganizations();
        Organization GetOrganization(int id);
        void AddOrganization(Organization organization);
        void DeleteOrganization(Organization organization);


        // Event
        IEnumerable<Event> GetEvents();
        Event GetEvent(int id);
        void AddEvent(Event esportEvent);
        void DeleteEvent(Event esportEvent);

        // Game
        IEnumerable<Game> GetGames();
        Game GetGame(int id);
        void AddGame(Game game);
        void DeleteGame(Game game);
    }
}
