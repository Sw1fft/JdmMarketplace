using JdmMarketplace.Services.CatalogAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace JdmMarketplace.Services.CatalogData
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
            : base() { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
