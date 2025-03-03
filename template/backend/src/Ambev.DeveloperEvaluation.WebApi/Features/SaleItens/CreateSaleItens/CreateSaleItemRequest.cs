namespace Ambev.DeveloperEvaluation.WebApi.Features.SaleItens.CreateSaleItens
{
    public class CreateSaleItemRequest
    {
        public decimal UnitPrice { get; set; }
        public bool IsCancelled { get; set; } = false;
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
    }
}
