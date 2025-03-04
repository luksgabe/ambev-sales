namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSales
{
    public class SaleItemResponse
    {
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalItemAmount { get; set; }
        public bool Cancelled { get; set; } = false;
        public ProductResponse Product { get; set; }
    }
}
