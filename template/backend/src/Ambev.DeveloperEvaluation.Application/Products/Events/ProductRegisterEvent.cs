using Ambev.DeveloperEvaluation.Application.Configuration.Messaging;

namespace Ambev.DeveloperEvaluation.Application.Products.Events
{
    public class ProductRegisterEvent : Event
    {
        public ProductRegisterEvent(string name, string? description, string? color, string? size)
        {
            Name=name;
            Description=description;
            Color=color;
            Size=size;
        }

        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string? Color { get; set; }
        public string? Size { get; set; }

    }
}
