using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsportEventBelgium.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; } // FPS, MOBA, etc...
    }
}
