using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.ORM.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using SharpCompress.Common;
using System.Text.RegularExpressions;

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

        public async Task<IEnumerable<Product>> GetFilteredProducts(string name, string description, string color, string size)
        {
            var filter = Builders<Product>.Filter.Empty;

            if (!string.IsNullOrEmpty(name))
            {
                filter = filter & Builders<Product>.Filter.Regex(p => p.Name, new BsonRegularExpression($".*{Regex.Escape(name)}.*", "i"));
            }

            if (!string.IsNullOrEmpty(description))
            {
                filter = filter & Builders<Product>.Filter.Regex(p => p.Description, new BsonRegularExpression($".*{Regex.Escape(description)}.*", "i"));
            }

            if (!string.IsNullOrEmpty(color))
            {
                filter = filter & Builders<Product>.Filter.Regex(p => p.Color, new BsonRegularExpression($".*{Regex.Escape(color)}.*", "i"));
            }

            if (!string.IsNullOrEmpty(size))
            {
                filter = filter & Builders<Product>.Filter.Regex(p => p.Size, new BsonRegularExpression($".*{Regex.Escape(size)}.*", "i"));
            }

            return await _productCollection.Find(filter).ToListAsync();
        }
    }
}
