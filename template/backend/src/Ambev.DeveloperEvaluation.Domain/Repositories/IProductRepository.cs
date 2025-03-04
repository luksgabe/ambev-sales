using Ambev.DeveloperEvaluation.Domain.Entities;

namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
        Task AddRangeNoSql(IEnumerable<Product> products);
        Task<IEnumerable<Product>> GetFilteredProducts(string name, string description, string color, string size);
    }
}
