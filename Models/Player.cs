using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_card_catalog.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LastFirst
        {
            get { return $"{LastName}, {FirstName}"; }

        }

        public virtual List<PlayerCard> PlayerCards { get; set; }
        public virtual List<PlayerTeam> PlayerTeams { get; set; }

    }
}
