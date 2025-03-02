using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.Domain.Validation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(product => product.Name)
                .NotEmpty()
                .MaximumLength(100).WithMessage("Product name cannot be longer than 100 characters.");

            RuleFor(product => product.Description)
                .MaximumLength(500).WithMessage("Product description cannot be longer than 500 characters.");

            RuleFor(product => product.Size)
                .NotEmpty()
                .MaximumLength(20).WithMessage("Product size cannot be longer than 20 characters.");


        }
    }
}
