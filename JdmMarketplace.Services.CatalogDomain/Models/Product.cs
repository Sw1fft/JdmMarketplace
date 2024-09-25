using System.ComponentModel.DataAnnotations;

namespace JdmMarketplace.Services.CatalogDomain.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Range(10, 1000)]
        public string? Description { get; set; }

        public decimal? Price { get; set; } = decimal.Zero;
    }
}
