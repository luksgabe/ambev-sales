using Ambev.DeveloperEvaluation.Application.Sales.GetSales;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSales
{
    public class GetSaleProfile : Profile
    {
        public GetSaleProfile()
        {
            CreateMap<ProductResult, ProductResponse>().ReverseMap();
            CreateMap<SaleItemResult, SaleItemResponse>().ReverseMap();

            CreateMap<GetSalesByIdResult, GetSaleByIdResponse>()
            .ForMember(dest => dest.SaleItens,
                opt => opt.MapFrom(src => src.SaleItens != null ? src.SaleItens.ToList() : new List<SaleItemResult>()));
        }
    }
}
