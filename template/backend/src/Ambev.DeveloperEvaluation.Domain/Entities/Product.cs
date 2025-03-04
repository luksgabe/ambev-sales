using Ambev.DeveloperEvaluation.Domain.Common;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }
        public override DateTime CreatedAt { get; set; }
        public override DateTime? UpdatedAt { get; set; }
    }
}
