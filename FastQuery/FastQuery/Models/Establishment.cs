using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastQuery.Models
{
    public class Establishment
    {
        
        public int EstablishmentId { get; set; }

        public string Name { get; set; }

        public int EstablishmentAdminId { get; set; }

        public int MenuId { get; set; }

        public virtual EstablishmentAdmin EstablishmentAdmin { get; set; }

        public IList<Order> Orders { get; set; }

        public virtual Menu Menu { get; set; }


    }
}
