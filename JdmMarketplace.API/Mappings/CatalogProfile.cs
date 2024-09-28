using JdmMarketplace.Services.CatalogDomain.Models;
using AutoMapper;
using JdmMarketplace.Services.CatalogAPI.DTO.Requests;

namespace JdmMarketplace.Services.CatalogAPI.Mappings
{
    public class CatalogProfile : Profile
    {
        public CatalogProfile()
        {
            CreateMap<RequestDTO, Product>().ReverseMap();
        }
    }
}
