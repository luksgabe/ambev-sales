namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.GetProducts
{
    public class GetProductRequest
    {
        public int Page { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
    }
}
