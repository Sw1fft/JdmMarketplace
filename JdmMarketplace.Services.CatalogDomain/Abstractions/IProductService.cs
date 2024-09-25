using JdmMarketplace.Services.CatalogDomain.Models;

namespace JdmMarketplace.Services.CatalogDomain.Abstractions
{
    public interface IProductService
    {
        public Task<List<Product>> GetProducts();

        public Task<Product> GetProductById(Guid id);

        public Task AddNewProduct(Product product);

        public Task<Product> UpdateProduct(Guid id, Product product);

        public Task DeleteProduct(Guid id);
    }
}
