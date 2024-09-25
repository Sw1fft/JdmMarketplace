using JdmMarketplace.Services.CatalogDomain.Models;
using Microsoft.AspNetCore.Mvc;

namespace JdmMarketplace.Services.CatalogAPI.Controllers
{
    public class CatalogController : ControllerBase
    {
        [HttpGet]
        public Task<List<Product>> GetAll()
        {

        }

        [HttpGet]
        [Route("{id:guid}")]
        public Task<Product> GetProductById(Guid id)
        {
            
        }
    }
}
