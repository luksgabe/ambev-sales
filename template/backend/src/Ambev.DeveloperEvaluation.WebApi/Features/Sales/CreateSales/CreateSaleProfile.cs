using Ambev.DeveloperEvaluation.Application.SaleItens;
using Ambev.DeveloperEvaluation.Application.SaleItens.CreateSaleItens;
using Ambev.DeveloperEvaluation.Application.Sales.CreateSales;
using Ambev.DeveloperEvaluation.WebApi.Features.SaleItens.CreateSaleItens;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales
{
    public class CreateSaleProfile : Profile
    {
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleItemRequest, CreateSaleItemCommand>();
            CreateMap<CreateSaleRequest, CreateSaleCommand>();
                

            CreateMap<CreateSaleResult, CreateSaleResponse>()
                .ConvertUsing(s => new CreateSaleResponse { Id = s.Id, SaleDate = s.SaleDate, CustomerId = s.CustomerId, BranchId = s.BranchId, Total = s.Total });
        }
    }
}
