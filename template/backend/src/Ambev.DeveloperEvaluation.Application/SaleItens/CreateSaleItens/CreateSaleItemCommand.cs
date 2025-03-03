
namespace Ambev.DeveloperEvaluation.Application.SaleItens.CreateSaleItens
{
    public class CreateSaleItemCommand
    {
        public decimal UnitPrice { get; set; }
        public bool IsCancelled { get; set; }
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
    
    }
}
