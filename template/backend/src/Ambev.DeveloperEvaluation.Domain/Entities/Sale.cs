using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Sale : BaseEntity
    {
        public DateTime SaleDate { get; set; }
        public Guid BranchId { get; set; }
        public Guid CustomerId { get; set; }
        
        public bool IsCancelled { get; set; }
        public ICollection<SaleItem> SaleItens { get; set; } = new List<SaleItem>();
        public decimal TotalSaleAmount { get; set; }
        public override DateTime CreatedAt { get; set; }
        public override DateTime? UpdatedAt { get; set; }

        public User Customer { get; set; }
        public Branch Branch { get; set; }
        public void SetTotalSaleAmount()
        {
            TotalSaleAmount = SaleItens.Sum(x => x.TotalItemAmount);
        }
    }
}
