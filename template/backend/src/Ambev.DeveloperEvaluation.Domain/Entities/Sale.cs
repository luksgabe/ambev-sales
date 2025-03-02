using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Sale : BaseEntity
    {
        public DateTime SaleDate { get; set; }
        public User Customer { get; set; }
        public Branch Branch { get; set; }
        public bool IsCancelled { get; set; }
        public List<SaleItem> SaleItems { get; set; } = new List<SaleItem>();
        public decimal TotalSaleAmount { get; set; }

        public override DateTime CreatedAt { get; set; }
        public override DateTime? UpdatedAt { get; set; }

        public void SetTotalSaleAmount()
        {
            TotalSaleAmount = SaleItems.Sum(x => x.TotalItemAmount);
        }
    }
}
