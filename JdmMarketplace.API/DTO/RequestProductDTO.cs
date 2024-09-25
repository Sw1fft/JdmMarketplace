using System.ComponentModel.DataAnnotations;

namespace JdmMarketplace.Services.CatalogAPI.DTO
{
    public class RequestProductDTO
    {
        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        public decimal? Price { get; set; }
    }
}
