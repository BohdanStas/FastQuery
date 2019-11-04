using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastQuery.Models
{
    public class Order
    {
        public int OrderId { get; set; }

        public int UserId { get; set; }

        public int EstablishmentId { get; set; }

        public int TotalPrice { get; set; }

        public DateTime Time { get; set; }

        public virtual User User { get; set; }

        public virtual Establishment Establishment { get; set; }





    }
}
