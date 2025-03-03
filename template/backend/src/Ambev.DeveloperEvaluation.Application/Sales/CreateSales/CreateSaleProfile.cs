using Ambev.DeveloperEvaluation.Application.SaleItens.CreateSaleItens;
using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;

/// <summary>
/// Profile for mapping between Sale entity and CreateSaleResponse
/// </summary>
namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSales
{
    public class CreateSaleProfile : Profile
    {
        public CreateSaleProfile()
        {
            CreateMap<CreateSaleItemCommand, SaleItem>();
            CreateMap<CreateSaleCommand, Sale>();
            CreateMap<Sale, CreateSaleResult>().ConvertUsing(s => new CreateSaleResult { Id = s.Id, SaleDate = s.SaleDate, CustomerId = s.CustomerId, BranchId = s.BranchId, Total = s.TotalSaleAmount });
        }
    }
}
