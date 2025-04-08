using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext() : base("OrderDataBase")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderDbContext>());
        }

        public DbSet<Order> Orders { get; set; }
    }
}
