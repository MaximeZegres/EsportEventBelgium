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



    }
}
