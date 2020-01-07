using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_card_catalog.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual List<Card> Cards { get; set; }
        public virtual List<Sport> Sports { get; set; }
        public virtual List<Player> Players { get; set; }
        public virtual List<Team> Teams { get; set; }
        public virtual List<Location> Locations { get; set; }

    }
}
