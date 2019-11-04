using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FastQuery.Models
{
    public class DataBaseContext : DbContext
    {


        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<EstablishmentAdmin> EstablishmentAdmins { get; set; }
        public DbSet<Establishment> Establishments { get; set; }
        public DbSet<Dish> Dishes  { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }

    }
}
