using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.ORM.Options;
using MongoDB.Driver;
using SharpCompress.Common;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly IMongoCollection<Product> _productCollection;
        public ProductRepository(DefaultContext context, IMongoDatabaseSettings mongoSettings) : base(context, mongoSettings)
        {
            var client = new MongoClient(mongoSettings.ConnectionString);
            var database = client.GetDatabase(mongoSettings.DatabaseName);

            _productCollection = database.GetCollection<Product>(nameof(Product));
            base.MongoDB(_productCollection);
        }

        public async Task AddRangeNoSql(IEnumerable<Product> products)
        {
            await _mongoContext.InsertManyAsync(products);
        }
    }
}
