using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_card_catalog.Models
{
    public class User
    {
        public int Id { get; set; }
        public int CatalogId { get; set; }
        public string Name { get; set; }
    }
}
