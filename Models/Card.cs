using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_card_catalog.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CatalogId { get; set; }
        public int SportId { get; set; }
        public int TeamId { get; set; }
        public int LocationId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Year { get; set; }
        public string PlayerYear { get; set; }
        public string Condition { get; set; }
        public string Era { get; set; }
        public string Manufacturer { get; set; }
        public string Original { get; set; }
        public string Psa { get; set; }
        public string Graded { get; set; }
        public string Grade { get; set; }
        public string Notes { get; set; }
      



    }
}
