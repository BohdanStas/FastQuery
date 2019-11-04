using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastQuery.Models
{
    public class Dish
    {
        public int DishId { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public virtual Menu Menu { get; set; }

    }
}
