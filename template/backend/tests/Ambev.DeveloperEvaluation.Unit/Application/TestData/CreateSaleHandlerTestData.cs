using Ambev.DeveloperEvaluation.Application.SaleItens.CreateSaleItens;
using Ambev.DeveloperEvaluation.Application.Sales.CreateSales;
using Ambev.DeveloperEvaluation.Application.Users.CreateUser;
using Bogus;

namespace Ambev.DeveloperEvaluation.Unit.Application.TestData
{
    public static class CreateSaleHandlerTestData
    {

        // Faker for sale items
        private static readonly Faker<CreateSaleItemCommand> createSaleItemCommandFaker = new Faker<CreateSaleItemCommand>()
            .RuleFor(si => si.ProductId, f => f.Random.Guid())
            .RuleFor(si => si.Quantity, f => f.Random.Number(1, 20))
            .RuleFor(si => si.UnitPrice, f => f.Finance.Amount(10, 100))
            .RuleFor(si => si.IsCancelled, f => f.Random.Bool());

        // Faker for sales
        private static readonly Faker<CreateSaleCommand> createSaleCommandFaker = new Faker<CreateSaleCommand>()
            .RuleFor(s => s.SaleDate, f => f.Date.Past())
            .RuleFor(s => s.BranchId, f => f.Random.Guid())
            .RuleFor(s => s.CustomerId, f => f.Random.Guid())
            .RuleFor(s => s.SaleItens, f => createSaleItemCommandFaker.Generate(f.Random.Number(1, 5)));


        public static CreateSaleItemCommand GenerateSaleItemValidCommand()
        {
            return createSaleItemCommandFaker.Generate();
        }

        public static CreateSaleCommand GenerateSaleValidCommand()
        {
            return createSaleCommandFaker.Generate();
        }

    }
}
