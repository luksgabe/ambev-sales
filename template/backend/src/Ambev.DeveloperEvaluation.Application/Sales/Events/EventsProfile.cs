using Ambev.DeveloperEvaluation.Domain.Entities;
using AutoMapper;
namespace Ambev.DeveloperEvaluation.Application.Sales.Events
{
    public class EventsProfile : Profile
    {
        public EventsProfile()
        {

            CreateMap<SaleItem, SaleItemRegisterEvent>()
                .ConstructUsing(saleItem => new SaleItemRegisterEvent(saleItem.Id, saleItem.UnitPrice, saleItem.Discount, saleItem.IsCancelled, saleItem.Quantity, saleItem.TotalItemAmount, saleItem.CreatedAt, saleItem.UpdatedAt, saleItem.SaleId, saleItem.ProductId))
                .ReverseMap();

            CreateMap<Sale, SaleRegisterEvent>()
                .ConstructUsing((createSale, t) => 
                    new SaleRegisterEvent(
                        createSale.Id,
                        createSale.SaleDate,
                        createSale.BranchId,
                        createSale.CustomerId,
                        createSale.IsCancelled,
                        t.Mapper.Map<List<SaleItemRegisterEvent>>(createSale.SaleItens),
                        createSale.TotalSaleAmount
                    )).ReverseMap();
        }
    }
}
