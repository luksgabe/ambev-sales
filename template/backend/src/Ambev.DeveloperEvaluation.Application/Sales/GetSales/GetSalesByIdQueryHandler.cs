using Ambev.DeveloperEvaluation.Domain.Repositories;
using AutoMapper;
using MediatR;

namespace Ambev.DeveloperEvaluation.Application.Sales.GetSales
{
    public class GetSalesByIdQueryHandler : IRequestHandler<GetSaleByIdQuery, GetSalesByIdResult>
    {
        public readonly ISaleRepository _saleRepository;
        public readonly IMapper _mapper;

        public GetSalesByIdQueryHandler(ISaleRepository saleRepository, IMapper mapper)
        {
            _saleRepository = saleRepository;
            _mapper = mapper;
        }

        public async Task<GetSalesByIdResult> Handle(GetSaleByIdQuery request, CancellationToken cancellationToken)
        {
            var sale = await _saleRepository.GetByIdNoSqlAsync(request.Id);
            return _mapper.Map<GetSalesByIdResult>(sale);
        }
    }

}
