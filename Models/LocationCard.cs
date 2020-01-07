using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_card_catalog.Models
{
    public class LocationCard
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int CardId { get; set; }
        public virtual Location Location { get; set; }
        public virtual Card Card { get; set; }
    }
}
