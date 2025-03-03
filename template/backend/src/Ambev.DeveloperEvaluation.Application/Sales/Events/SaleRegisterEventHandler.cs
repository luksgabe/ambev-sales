using Ambev.DeveloperEvaluation.Domain.SeedWork;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Sales.Events
{
    public class SaleRegisterEventHandler : IEventHandler<SaleRegisterEvent>, IEventHandler<SaleItemRegisterEvent>
    {
        private readonly IMapper _mapper;
        public SaleRegisterEventHandler(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task Handle(SaleRegisterEvent @event, CancellationToken cancellationToken)
        {
            //Do something
        }

        public Task Handle(SaleItemRegisterEvent @event, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
