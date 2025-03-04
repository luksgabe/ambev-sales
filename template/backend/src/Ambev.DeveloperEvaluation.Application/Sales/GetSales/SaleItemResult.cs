namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales
{
    public class SaleItemResult
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalItemAmount { get; set; }
        public bool Cancelled { get; set; } = false;
        public ProductResult Product { get; set; }
    }
}
