using Ambev.DeveloperEvaluation.WebApi.Features.SaleItens.CreateSaleItens;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales
{
    public class CreateSaleRequest
    {
        public DateTime SaleDate { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BranchId { get; set; }
        public List<CreateSaleItemRequest> SaleItens { get; set; } = new List<CreateSaleItemRequest>();
    }
}
