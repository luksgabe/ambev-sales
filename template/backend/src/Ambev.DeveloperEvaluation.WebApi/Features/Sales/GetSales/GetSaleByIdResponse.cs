namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.GetSales
{
    public class GetSaleByIdResponse
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }
        public decimal TotalSaleAmout { get; set; }
        public string Branch { get; set; }
        public IEnumerable<SaleItemResponse> SaleItens { get; set; }
    }
}
