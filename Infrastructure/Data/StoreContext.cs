using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        // DbSet is a collection of entities that represent a table or view in the database
        public DbSet<Product> Products { get; set; }
    }
}