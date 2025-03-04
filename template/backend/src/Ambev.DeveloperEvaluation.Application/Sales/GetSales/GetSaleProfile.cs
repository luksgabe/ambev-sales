using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales
{
    public class GetSaleProfile : Profile
    {
        public GetSaleProfile()
        {
            CreateMap<Product, ProductResult>();

            CreateMap<SaleItem, SaleItemResult>();

            CreateMap<Sale, GetSalesByIdResult>()
            .ForMember(dest => dest.Branch, opt => opt.MapFrom(src => src.Branch != null ? src.Branch.Name : string.Empty))
            .ForMember(dest => dest.Customer, opt => opt.MapFrom(src => src.Customer != null ? src.Customer.Username : string.Empty))
            .ForMember(dest => dest.TotalSaleAmout, opt => opt.MapFrom(src => src.TotalSaleAmount))
            .ForMember(dest => dest.SaleItens, opt => opt.MapFrom(src =>
                src.SaleItens != null
                    ? src.SaleItens.ToList()
                    : new List<SaleItem>()));
        }
    }
}
