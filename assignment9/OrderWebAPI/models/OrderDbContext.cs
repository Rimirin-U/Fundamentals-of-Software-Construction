using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp
{
    public class OrderDbContext : DbContext
    {
        //public OrderDbContext() : base("OrderDataBase")
        //{
        //    Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderDbContext>());
        //}

        public OrderDbContext(DbContextOptions<OrderDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Order> Orders { get; set; }
    }
}
