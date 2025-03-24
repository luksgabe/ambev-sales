using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Products.CreateProduct
{
    public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
    {
        public CreateProductRequestValidator()
        {
            RuleFor(product => product.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Product name must be provided")
                .MinimumLength(5)
                    .WithMessage("Product name must have more than 5 characters")
                .MaximumLength(50)
                    .WithMessage("Product name must have less than 50 characters");

            RuleFor(product => product.Description)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Product description must be provided")
                .MinimumLength(5)
                    .WithMessage("Product description must have more than 5 characters")
                .MaximumLength(500)
                    .WithMessage("Product description must have less than 500 characters");

            RuleFor(product => product.Color)
                .MaximumLength(15)
                    .WithMessage("Product color must have less than 15 characters");

            RuleFor(product => product.Size)
                .MaximumLength(10)
                    .WithMessage("Product size must have less than 10 characters");
        }
    }
}
