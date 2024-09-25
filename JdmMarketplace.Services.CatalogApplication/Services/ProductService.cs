using JdmMarketplace.Services.CatalogDomain.Abstractions;
using JdmMarketplace.Services.CatalogDomain.Models;
using JdmMarketplace.Services.CatalogData.Entities;
using JdmMarketplace.Services.CatalogData;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace JdmMarketplace.Services.CatalogApplication.Services
{
    public class ProductService : IProductService
    {
        private readonly CatalogDbContext _dbContext;
        private readonly IMapper _mapper;

        public ProductService(CatalogDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task AddNewProduct(Product product)
        {
            var entity = new ProductEntity
            {
                Id = Guid.NewGuid(),
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
            };

            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Product>> GetProducts()
        {
            var list = await _dbContext.Products.ToListAsync();

            return _mapper.Map<List<Product>>(list);
        }

        public Task<Product> GetProductById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProduct(Guid id, Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
