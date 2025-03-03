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
            CreateMap<CreateSaleCommand, Sale>();
            CreateMap<Sale, CreateSaleResult>();
        }
    }
}
