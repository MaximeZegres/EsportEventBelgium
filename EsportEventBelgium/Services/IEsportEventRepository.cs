using EsportEventBelgium.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportEventBelgium.Services
{
    public interface IEsportEventRepository
    {
        IEnumerable<Organization> GetOrganizations();
        Organization GetOrganization(int id);
        void AddOrganization(Organization organization);
        void DeleteOrganization(Organization organization);

    }
}
