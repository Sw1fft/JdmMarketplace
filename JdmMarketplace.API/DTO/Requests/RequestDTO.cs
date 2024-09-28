using System.ComponentModel.DataAnnotations;

namespace JdmMarketplace.Services.CatalogAPI.DTO.Requests
{
    public class RequestDTO
    {
        [Required]
        [Range(5, 15)]
        public string? Name { get; set; }

        [Range(10, 1000)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; } = decimal.Zero;
    }
}
