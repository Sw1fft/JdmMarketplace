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
        public async Task<ResponseDTO> CreateProduct([FromBody] RequestDTO request)
        {
            try
            {
                _response.Result = await _productService.AddNewProduct(_mapper.Map<Product>(request));
                _response.IsSuccess = true;
                _response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = ex.Message;
                _response.StatusCode = StatusCodes.Status400BadRequest;
            }

            return _response;
        }

        [HttpGet]
        public async Task<ResponseDTO> GetAll()
        {
            try
            {
                var productsList = await _productService.GetProducts();

                _response.Result = productsList;
                _response.IsSuccess = true;
                _response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.StatusCode = StatusCodes.Status400BadRequest;
                _response.ErrorMessage = ex.Message;
            }

            return _response;
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<ResponseDTO> GetProductById(Guid id)
        {
            try
            {
                var product = await _productService.GetProductById(id);
                _response.Result = product;
                _response.IsSuccess = true;
                _response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.StatusCode = StatusCodes.Status400BadRequest;
                _response.ErrorMessage = ex.Message;
            }

            return _response;
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<ResponseDTO> UpdateProduct(Guid id, [FromBody] Product product)
        {
            try
            {
                _response.Result = await _productService.UpdateProduct(id, product);
                _response.IsSuccess = true;
                _response.StatusCode = StatusCodes.Status200OK;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.StatusCode = StatusCodes.Status400BadRequest;
                _response.ErrorMessage = ex.Message;
            }

            return _response;
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<ResponseDTO> DeleteProduct(Guid id)
        {
            try
            {
                await _productService.DeleteProduct(id);
                _response.IsSuccess = true;
                _response.StatusCode= StatusCodes.Status200OK;
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.StatusCode = StatusCodes.Status400BadRequest;
                _response.ErrorMessage = ex.Message;
            }

            return _response;
        }
    }
}
