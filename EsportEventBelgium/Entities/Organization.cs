using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EsportEventBelgium.Entities
{
    public class Organization
    {
        [Key]
        public int OrganizationId { get; set; }
        public string Name { get; set; }
        public string UrlWebsite { get; set; }
        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
