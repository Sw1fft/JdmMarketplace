using AutoMapper;
using JdmMarketplace.Services.CatalogData.Entities;
using JdmMarketplace.Services.CatalogDomain.Models;

namespace JdmMarketplace.Services.CatalogApplication.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductEntity>().ReverseMap();
        }
    }
}
