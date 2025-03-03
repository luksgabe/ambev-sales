namespace Ambev.DeveloperEvaluation.Application.SaleItens
{
    public abstract class SaleItemCommand
    {
        public decimal UnitPrice { get; protected set; }
        public bool IsCancelled { get; protected set; }
        public int Quantity { get; protected set; }
        public Guid ProductId { get; protected set; }
    }
}
