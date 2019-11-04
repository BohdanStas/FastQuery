using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastQuery.Models
{
    public class EstablishmentAdmin
    {
        public int EstablishmentAdminId { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronomic { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Phone { get; set; }

        public IList<Establishment> Establishments { get; set; }


    }
}
