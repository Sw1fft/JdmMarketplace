using JdmMarketplace.Services.CatalogDomain.Models;
using JdmMarketplace.Services.CatalogAPI.DTO;
using AutoMapper;

namespace JdmMarketplace.Services.CatalogAPI.Mappings
{
    public class CatalogProfile : Profile
    {
        public CatalogProfile()
        {
            CreateMap<RequestProductDTO, Product>().ReverseMap();
        }
    }
}
