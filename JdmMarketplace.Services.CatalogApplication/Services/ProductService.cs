using JdmMarketplace.Services.CatalogDomain.Abstractions;
using JdmMarketplace.Services.CatalogDomain.Models;

namespace JdmMarketplace.Services.CatalogApplication.Services
{
    public class ProductService : IProductService
    {


        public ProductService()
        {

        }

        public Task AddNewProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProducts()
        {
            throw new NotImplementedException();
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
