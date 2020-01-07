using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_card_catalog.Models
{
    public class Team
    {
        public int Id { get; set; }
        public int SportId { get; set; }
        public string Name { get; set; }
        public virtual List<PlayerTeam> PlayerTeams { get; set; }
        public virtual List<TeamCard> TeamCards { get; set; }
    }
}
