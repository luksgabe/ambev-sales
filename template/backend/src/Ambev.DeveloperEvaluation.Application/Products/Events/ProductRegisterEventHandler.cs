using Ambev.DeveloperEvaluation.Application.Sales.Events;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.SeedWork;
using AutoMapper;

namespace Ambev.DeveloperEvaluation.Application.Products.Events
{
    public class ProductRegisterEventHandler : IEventHandler<ProductRegisterEvent>
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductRegisterEventHandler(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public async Task Handle(ProductRegisterEvent @event, CancellationToken cancellationToken)
        {
            var product = _mapper.Map<Product>(@event);

            await _productRepository.CreateNoSql(product);
        }
    }
}
