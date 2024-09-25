using Microsoft.EntityFrameworkCore.Metadata.Builders;
using JdmMarketplace.Services.CatalogData.Entities;
using Microsoft.EntityFrameworkCore;

namespace JdmMarketplace.Services.CatalogData.Configurations
{
    internal class CatalogConfiguration : IEntityTypeConfiguration<ProductEntity>
    {
        public void Configure(EntityTypeBuilder<ProductEntity> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
