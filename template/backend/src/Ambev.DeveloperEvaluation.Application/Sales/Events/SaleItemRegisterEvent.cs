using Ambev.DeveloperEvaluation.Application.Configuration.Messaging;

namespace Ambev.DeveloperEvaluation.Application.Sales.Events
{
    public class SaleItemRegisterEvent : Event
    {
        public SaleItemRegisterEvent(Guid id, decimal unitPrice, decimal discount, bool isCancelled, int quantity, decimal totalItemAmount, DateTime createdAt, DateTime? updatedAt, Guid saleId, Guid productId)
        {
            Id=id;
            UnitPrice=unitPrice;
            Discount=discount;
            IsCancelled=isCancelled;
            Quantity=quantity;
            TotalItemAmount=totalItemAmount;
            CreatedAt=createdAt;
            UpdatedAt=updatedAt;
            SaleId=saleId;
            ProductId=productId;
        }

        public Guid Id { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public bool IsCancelled { get; set; }
        public int Quantity { get; set; }
        public decimal TotalItemAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid SaleId { get; set; }
        public Guid ProductId { get; set; }
    }
}
