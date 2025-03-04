using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales
{
    public class GetSaleByIdQuery : IRequest<GetSalesByIdResult>
    {
        public Guid Id { get; set; }
    }
}
