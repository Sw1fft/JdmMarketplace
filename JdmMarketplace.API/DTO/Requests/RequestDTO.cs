using System.ComponentModel.DataAnnotations;

namespace JdmMarketplace.Services.CatalogAPI.DTO.Requests
{
    public class RequestDTO
    {
        [Required]
        public string? Name { get; set; }

        public string? Description { get; set; }

        [Required]
        public decimal Price { get; set; } = decimal.Zero;
    }
}
