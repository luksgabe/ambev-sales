﻿using Ambev.DeveloperEvaluation.Application.Sales.CreateSales;
using Ambev.DeveloperEvaluation.Application.Users.CreateUser;
using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.Domain.SeedWork;
using Ambev.DeveloperEvaluation.ORM.Repositories;
using Ambev.DeveloperEvaluation.Unit.Application.TestData;
using Ambev.DeveloperEvaluation.Unit.Domain;
using AutoMapper;
using FluentAssertions;
using NSubstitute;
using System.Security.Cryptography.Xml;
using Xunit;

namespace Ambev.DeveloperEvaluation.Unit.Application
{
    public class CreateSaleHandlerTest
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ISaleRepository _saleRepository;
        private readonly IMapper _mapper;
        private readonly CreateSaleHandler _handler;

        public CreateSaleHandlerTest()
        {
            _unitOfWork = Substitute.For<IUnitOfWork>();
            _saleRepository = Substitute.For<ISaleRepository>();
            _mapper = Substitute.For<IMapper>();
            _handler = new CreateSaleHandler(_unitOfWork, _saleRepository, _mapper);
        }

        /// <summary>
        /// Tests that a valid user creation request is handled successfully.
        /// </summary>
        [Fact(DisplayName = "Given valid sale data When creating sale Then returns success response")]
        public async Task Handle_ValidRequest_ReturnsSuccessResponse()
        {
            // Given
            var saleCommand = CreateSaleHandlerTestData.GenerateSaleValidCommand();
            var saleItemCommand = CreateSaleHandlerTestData.GenerateSaleItemValidCommand();

            var sale = new Sale
            {
                Id = Guid.NewGuid(),
                SaleDate = saleCommand.SaleDate,
                BranchId = saleCommand.BranchId,
                CustomerId = saleCommand.CustomerId,
                SaleItens = _mapper.Map<List<SaleItem>>(saleCommand.SaleItens)
            };

            var result = new CreateSaleResult
            {
                Id = sale.Id,
                SaleDate = sale.SaleDate,
                BranchId = sale.BranchId,
                CustomerId = sale.CustomerId,
                Total = sale.TotalSaleAmount,
            };

            _mapper.Map<Sale>(saleCommand).Returns(sale);
            _mapper.Map<CreateSaleResult>(sale).Returns(result);


            _saleRepository.CreateAsync(Arg.Any<Sale>(), Arg.Any<CancellationToken>())
                .Returns(sale);


            // When
            var createSaleResult = await _handler.Handle(saleCommand, CancellationToken.None);

            // Then
            createSaleResult.Should().NotBeNull();
            createSaleResult.Should().NotBeNull();
            createSaleResult.Id.Should().Be(sale.Id);
            await _saleRepository.Received(1).CreateAsync(Arg.Any<Sale>(), Arg.Any<CancellationToken>());
        }

        /// <summary>
        /// Tests that an invalid sale creation request throws a validation exception.
        /// </summary>
        [Fact(DisplayName = "Given invalid sale data When creating sale Then throws validation exception")]
        public async Task Handle_InvalidRequest_ThrowsValidationException()
        {
            // Given
            var command = new CreateSaleCommand(); // Empty command will fail validation

            // When
            var act = () => _handler.Handle(command, CancellationToken.None);

            // Then
            await act.Should().ThrowAsync<FluentValidation.ValidationException>();
        }

        /// <summary>
        /// Tests that the total sale amount is correctly calculated before saving the sale.
        /// </summary>
        [Fact(DisplayName = "Given sale creation request When handling Then total sale amount is calculated")]
        public async Task Handle_ValidRequest_CalculatesTotalSaleAmount()
        {
            // Given
            var command = CreateSaleHandlerTestData.GenerateSaleValidCommand();
            var sale = new Sale
            {
                Id = Guid.NewGuid(),
                BranchId = command.BranchId,
                CustomerId = command.CustomerId,
                SaleDate = command.SaleDate,
                SaleItens = command.SaleItens.Select(si => new SaleItem
                {
                    ProductId = si.ProductId,
                    Quantity = si.Quantity,
                    UnitPrice = si.UnitPrice,
                    IsCancelled = si.IsCancelled
                }).ToList()
            };
            sale.SetTotalSaleAmount();

            _mapper.Map<Sale>(command).Returns(sale);
            _saleRepository.CreateAsync(Arg.Any<Sale>(), Arg.Any<CancellationToken>())
                .Returns(sale);

            // When
            await _handler.Handle(command, CancellationToken.None);

            // Then
            await _saleRepository.Received(1).CreateAsync(
                Arg.Is<Sale>(s => s.TotalSaleAmount == sale.TotalSaleAmount),
                Arg.Any<CancellationToken>());
        }

        /// <summary>
        /// Tests that the mapper is called with the correct command.
        /// </summary>
        [Fact(DisplayName = "Given valid command When handling Then maps command to sale entity")]
        public async Task Handle_ValidRequest_MapsCommandToSale()
        {
            // Given
            var command = CreateSaleHandlerTestData.GenerateSaleValidCommand();
            var sale = new Sale
            {
                Id = Guid.NewGuid(),
                BranchId = command.BranchId,
                CustomerId = command.CustomerId,
                SaleDate = command.SaleDate,
                SaleItens = command.SaleItens.Select(si => new SaleItem
                {
                    ProductId = si.ProductId,
                    Quantity = si.Quantity,
                    UnitPrice = si.UnitPrice,
                    IsCancelled = si.IsCancelled
                }).ToList()

            };
            sale.SetTotalSaleAmount();

            _mapper.Map<Sale>(command).Returns(sale);
            _saleRepository.CreateAsync(Arg.Any<Sale>(), Arg.Any<CancellationToken>())
                .Returns(sale);

            // When
            await _handler.Handle(command, CancellationToken.None);

            // Then
            _mapper.Received(1).Map<Sale>(Arg.Is<CreateSaleCommand>(c =>
                c.BranchId == command.BranchId &&
                c.CustomerId == command.CustomerId &&
                c.SaleDate == command.SaleDate &&
                c.SaleItens.Count == command.SaleItens.Count));
        }
    }
}
