using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_card_catalog.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Card> Cards { get; set; }


    }
}
