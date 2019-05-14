using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportEventBelgium.Entities
{
    public class EsportEventContext : DbContext
    {
        public EsportEventContext(DbContextOptions <EsportEventContext> options)
            : base (options)
        {
        }

        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
