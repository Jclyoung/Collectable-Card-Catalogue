using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_card_catalog.Models
{
    public class TeamCard
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        public virtual Player Player { get; set; }
    }
}
