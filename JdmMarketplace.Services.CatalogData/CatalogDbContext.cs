using JdmMarketplace.Services.CatalogData.Configurations;
using JdmMarketplace.Services.CatalogData.Entities;
using Microsoft.EntityFrameworkCore;

namespace JdmMarketplace.Services.CatalogData
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext(DbContextOptions<CatalogDbContext> options)
            : base(options) { }

        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CatalogConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
