using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastQuery.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        IList<Dish> Dishes { get; set; }
    }
}
