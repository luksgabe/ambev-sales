using Ambev.DeveloperEvaluation.Application.SaleItens.CreateSaleItens;
using Ambev.DeveloperEvaluation.Common.Validation;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSales
{
    public class CreateSaleCommand : SaleCommand, IRequest<CreateSaleResult>
    {
        public CreateSaleCommand(DateTime saleDate, Guid customerId, Guid branchId, List<CreateSaleItemCommand> saleItens)
        {
            SaleDate = saleDate;
            CustomerId = customerId;
            BranchId = branchId;
            SaleItens = saleItens;
        }

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
