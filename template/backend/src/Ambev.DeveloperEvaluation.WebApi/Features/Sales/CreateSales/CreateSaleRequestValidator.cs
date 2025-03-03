using Ambev.DeveloperEvaluation.Domain.Entities;
using FluentValidation;

namespace Ambev.DeveloperEvaluation.WebApi.Features.Sales.CreateSales
{
    /// <summary>
    /// Validator for CreateSaleRequestValidator that defines validation rules for sales creation.
    /// </summary>
    public class CreateSaleRequestValidator : AbstractValidator<CreateSaleRequest>
    {
        /// <summary>
        /// Initializes a new instance of the CreateSaleRequestValidator with defined validation rules.
        /// </summary>
        /// <remarks>
        /// Validation rules include:
        /// - SaleDate: Sale date must be provided
        /// - CustomerId: Customer must be provided
        /// - BranchId: Branch must be provided
        /// - SaleItens: Sale itens must be provided
        /// - SaleItens: Each sale item must have a quantity greater than 0
        /// - SaleItens: Each sale item must have a product
        /// - SaleItens: Each sale item must have a unit price
        /// </remarks>
        public CreateSaleRequestValidator()
        {
            RuleFor(sale => sale.SaleDate)
                .NotEmpty()
                .WithMessage("Sale date must be provided");

            RuleFor(sale => sale.CustomerId)
                .NotEmpty()
                .WithMessage("Customer must be provided");

            RuleFor(sale => sale.BranchId)
                .NotEmpty()
                .WithMessage("Branch must be provided");

            RuleFor(sale => sale.SaleItens)
                .Must(saleItens => saleItens.Any())
                .WithMessage("Sale itens must be provided");

            RuleFor(sale => sale.SaleItens)
                .Must(saleItens => saleItens.All(p => p.Quantity > 0))
                .WithMessage("Each sale item must have a quantity greater than 0");

            RuleFor(sale => sale.SaleItens)
                .Must(saleItens => saleItens.All(p => p.ProductId != Guid.Empty))
                .WithMessage("Each sale item must have a product");

            RuleFor(sale => sale.SaleItens)
                .Must(saleItens => saleItens.All(p => p.UnitPrice > 0))
                .WithMessage("Each sale item must have a unit price");
        }
    }
}
