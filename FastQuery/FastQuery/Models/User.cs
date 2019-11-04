using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastQuery.Models
{
    public class User
    {

        public int UserId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronomic { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }


        public virtual IList<Order> Orders { get; set; } //LazyLoading 



    }
}
