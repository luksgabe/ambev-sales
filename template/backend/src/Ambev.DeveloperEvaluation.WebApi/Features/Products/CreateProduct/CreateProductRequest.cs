using Ambev.DeveloperEvaluation.Application.SaleItens.CreateSaleItens;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    public class CreateProductRequest
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
    }
}
