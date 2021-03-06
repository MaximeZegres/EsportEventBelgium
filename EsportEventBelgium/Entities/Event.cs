﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportEventBelgium.Entities
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Organization Organization { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public ICollection<Game> Games { get; set; }
    }
}
