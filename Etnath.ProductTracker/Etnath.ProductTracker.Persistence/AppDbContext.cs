using Etnath.ProductTracker.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etnath.ProductTracker.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
