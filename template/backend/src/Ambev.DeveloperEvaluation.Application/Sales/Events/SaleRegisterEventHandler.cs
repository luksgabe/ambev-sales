using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.SeedWork;
using AutoMapper;
using System.Runtime.CompilerServices;

namespace Ambev.DeveloperEvaluation.Application.Sales.Events
{
    public class SaleRegisterEventHandler : IEventHandler<SaleRegisterEvent>, IEventHandler<SaleItemRegisterEvent>
    {
        private readonly IMapper _mapper;
        private readonly ISaleRepository _saleRepository;
        private readonly IUserRepository _userRepository;
        private readonly IBranchRepository _branchRepository;

        public SaleRegisterEventHandler(IMapper mapper, ISaleRepository saleRepository, IUserRepository userRepository, IBranchRepository branchRepository)
        {
            _mapper = mapper;
            _saleRepository = saleRepository;
            _userRepository = userRepository;
            _branchRepository=branchRepository;
        }
        public async Task Handle(SaleRegisterEvent @event, CancellationToken cancellationToken)
        {
            var sale = _mapper.Map<Sale>(@event);
            var user = await _userRepository.GetByIdAsync(@event.CustomerId);
            var branch = await _branchRepository.GetByIdNoSqlAsync(@event.BranchId);

            sale.SetCustomer(user!);
            sale.SetBranch(branch!);

            await _saleRepository.CreateNoSql(sale);
        }

        public Task Handle(SaleItemRegisterEvent @event, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
