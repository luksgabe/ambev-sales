namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales
{
    public class GetSalesByIdResult
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }
        public decimal TotalSaleAmout { get; set; }
        public string Branch { get; set; }
        public IEnumerable<SaleItemResult> SaleItens { get; set; } = Enumerable.Empty<SaleItemResult>();
    }
}
