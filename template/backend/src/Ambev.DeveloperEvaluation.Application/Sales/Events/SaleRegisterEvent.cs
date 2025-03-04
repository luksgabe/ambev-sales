using Ambev.DeveloperEvaluation.Application.Configuration.Messaging;
using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Application.Sales.Events
{
    public class SaleRegisterEvent : Event
    {
        public SaleRegisterEvent(Guid id, DateTime saleDate, Guid branchId, Guid customerId, bool isCancelled, List<SaleItemRegisterEvent> saleItens, decimal totalSaleAmount)
        {
            Id=id;
            SaleDate=saleDate;
            BranchId=branchId;
            CustomerId=customerId;
            IsCancelled=isCancelled;
            SaleItens=saleItens;
            TotalSaleAmount=totalSaleAmount;
        }
        public Guid Id { get; set; }
        public DateTime SaleDate { get; set; }
        public Guid BranchId { get; set; }
        public Guid CustomerId { get; set; }

        public bool IsCancelled { get; set; }
        public IEnumerable<SaleItemRegisterEvent> SaleItens { get; set; } = new List<SaleItemRegisterEvent>();
        public decimal TotalSaleAmount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }


    }
}
