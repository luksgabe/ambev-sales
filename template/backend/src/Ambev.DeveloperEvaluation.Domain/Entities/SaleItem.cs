using Ambev.DeveloperEvaluation.Domain.Common;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class SaleItem : BaseEntity
    {
        private int quantity;

        
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; private set; }
        public bool IsCancelled { get; set; }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value > 20)
                {
                    throw new ArgumentException("Cannot sell more than 20 identical items.");
                }
                quantity = value;
                CalculateDiscount();
            }
        }
        public decimal TotalItemAmount => (UnitPrice * Quantity) - (UnitPrice * Quantity * Discount);
        public override DateTime CreatedAt { get; set; }
        public override DateTime? UpdatedAt { get; set; }
        public Guid SaleId { get; set; }
        public Sale Sale { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        private void CalculateDiscount()
        {
            if (Quantity >= 10 && Quantity <= 20)
            {
                Discount = 0.20m;
            }
            else if (Quantity >= 4)
            {
                Discount = 0.10m;
            }
            else
            {
                Discount = 0m;
            }
        }


    }
}
