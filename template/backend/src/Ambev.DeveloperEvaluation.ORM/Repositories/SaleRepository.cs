using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.ORM.Options;
using MongoDB.Driver;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class SaleRepository : Repository<Sale>, ISaleRepository
    {
        private readonly IMongoCollection<Sale> _saleCollection;

        public SaleRepository(DefaultContext context, IMongoDatabaseSettings mongoSettings) : base(context, mongoSettings)
        {
            var client = new MongoClient(mongoSettings.ConnectionString);
            var database = client.GetDatabase(mongoSettings.DatabaseName);

            _saleCollection = database.GetCollection<Sale>(nameof(Sale));
            base.MongoDB(_saleCollection);
        }


    }
}
