using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportEventBelgium.Entities
{
    public class Organization
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UrlWebsite { get; set; }
        public ICollection<Event> Events { get; set; } = new List<Event>();

    }
}
