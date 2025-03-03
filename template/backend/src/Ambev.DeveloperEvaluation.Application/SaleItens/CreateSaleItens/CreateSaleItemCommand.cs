
namespace Ambev.DeveloperEvaluation.Application.SaleItens.CreateSaleItens
{
    public class CreateSaleItemCommand : SaleItemCommand
    {
        public CreateSaleItemCommand(decimal unitPrice, bool isCanceled, int quantity, Guid productId)
        {
            UnitPrice = unitPrice;
            IsCancelled = isCanceled;
            Quantity = quantity;
            ProductId = productId;
        }

        //public ValidationResultDetail Validate()
        //{
        //    var validator = new CreateUserCommandValidator();
        //    var result = validator.Validate(this);
        //    return new ValidationResultDetail
        //    {
        //        IsValid = result.IsValid,
        //        Errors = result.Errors.Select(o => (ValidationErrorDetail)o)
        //    };
        //}
    }
}
