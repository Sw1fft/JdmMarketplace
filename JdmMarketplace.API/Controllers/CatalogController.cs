using JdmMarketplace.Services.CatalogDomain.Abstractions;
using JdmMarketplace.Services.CatalogDomain.Models;
using JdmMarketplace.Services.CatalogAPI.DTO;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace JdmMarketplace.Services.CatalogAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public CatalogController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct([FromBody] RequestProductDTO request)
        {
            await _productService.AddNewProduct(_mapper.Map<Product>(request));

            return Ok();
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var productsList = await _productService.GetProducts();

            return Ok(productsList);   
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<ActionResult> GetProductById(Guid id)
        {
            var product = await _productService.GetProductById(id);

            return Ok(product);
        }
    }
}
