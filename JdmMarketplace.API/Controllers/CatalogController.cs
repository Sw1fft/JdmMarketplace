using JdmMarketplace.Services.CatalogDomain.Abstractions;
using JdmMarketplace.Services.CatalogAPI.DTO.Responses;
using JdmMarketplace.Services.CatalogAPI.DTO.Requests;
using JdmMarketplace.Services.CatalogDomain.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;

namespace JdmMarketplace.Services.CatalogAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly ResponseDTO _response;
        private readonly IMapper _mapper;

        public CatalogController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _response = new ResponseDTO();
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult> CreateProduct([FromBody] RequestDTO request)
        {
            await _productService.AddNewProduct(_mapper.Map<Product>(request));

            return Ok();
        }

        [HttpGet]
        public async Task<ResponseDTO> GetAll()
        {
            var productsList = await _productService.GetProducts();

            if (productsList != null)
            {
                _response.Result = productsList;
                _response.IsSuccess = true;
                _response.StatusCode = StatusCodes.Status200OK;

                return _response;
            }

            _response.ErrorMessage = "Error";
            _response.StatusCode = StatusCodes.Status400BadRequest;

            return _response;
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
