using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_card_catalog.Models
{
    public class PlayerCard
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int CardId { get; set; }
        public virtual Card Card { get; set; }
        public virtual Player Player { get; set; }
    }
}
