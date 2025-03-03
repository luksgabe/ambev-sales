using Ambev.DeveloperEvaluation.Application.Sales.Events;
using Ambev.DeveloperEvaluation.Application.Users.CreateUser;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.SeedWork;
using AutoMapper;
using FluentValidation;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Ambev.DeveloperEvaluation.Application.Sales.CreateSales
{
    /// <summary>
    /// Handler for processing CreateSaleHandler requests
    /// </summary>
    public class CreateSaleHandler : IRequestHandler<CreateSaleCommand, CreateSaleResult>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of CreateSaleHandler
        /// </summary>
        /// <param name="unitOfWork">The unitofwork</param>
        /// <param name="saleRepository">The sale repository</param>
        /// <param name="mapper">The AutoMapper instance</param>
        /// <param name="validator">The validator for CreateSaleCommand</param>
        public CreateSaleHandler(IUnitOfWork unitOfWork, ISaleRepository saleRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _saleRepository = saleRepository;
            _mapper = mapper;
        }

        public async Task<CreateSaleResult> Handle(CreateSaleCommand command, CancellationToken cancellationToken)
        {
            var validator = new CreateSaleCommandValidator();
            var validationResult = await validator.ValidateAsync(command, cancellationToken);

            if (!validationResult.IsValid)
                throw new ValidationException(validationResult.Errors);

            var sale = _mapper.Map<Sale>(command);

            sale.Id = Guid.NewGuid();
            sale.CreatedAt = DateTime.Now.ToUniversalTime();

            foreach (var saleItem in sale.SaleItens)
            {
                saleItem.Id = Guid.NewGuid();
                saleItem.SaleId = sale.Id;
                saleItem.CreatedAt = DateTime.Now.ToUniversalTime();
            }

            sale.SetTotalSaleAmount();

            sale.AddDomainEvent(_mapper.Map<SaleRegisterEvent>(sale));

            var createSale = await _saleRepository.CreateAsync(sale, cancellationToken);

            await _unitOfWork.CommitAsync(cancellationToken);

            return  _mapper.Map<CreateSaleResult>(createSale);
        }
    }
}
