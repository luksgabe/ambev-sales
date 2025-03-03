using Ambev.DeveloperEvaluation.Application.SaleItens;
using Ambev.DeveloperEvaluation.Application.SaleItens.CreateSaleItens;
using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSales
{
    public class CreateSaleCommand : IRequest<CreateSaleResult>
    {
        public DateTime SaleDate { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BranchId { get; set; }
        public List<CreateSaleItemCommand> SaleItens { get; set; } = new List<CreateSaleItemCommand>();


        public ValidationResultDetail Validate()
        {
            var validator = new CreateSaleCommandValidator();
            var result = validator.Validate(this);
            return new ValidationResultDetail
            {
                IsValid = result.IsValid,
                Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
            };
        }
    }
}
