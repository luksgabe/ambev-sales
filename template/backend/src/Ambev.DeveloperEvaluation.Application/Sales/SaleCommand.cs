using Ambev.DeveloperEvaluation.Application.SaleItens;

namespace Ambev.DeveloperEvaluation.Application.Sales
{
    public abstract class SaleCommand
    {
        public Guid Id { get; protected set; }
        public DateTime SaleDate { get; protected set; }
        public Guid CustomerId { get; protected set; }
        public Guid BranchId { get; protected set; }
        public IEnumerable<SaleItemCommand> SaleItens { get; protected set; } = new List<SaleItemCommand>();
    }
}
