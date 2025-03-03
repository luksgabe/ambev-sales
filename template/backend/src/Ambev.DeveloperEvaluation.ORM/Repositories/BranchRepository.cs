using Ambev.DeveloperEvaluation.Domain.Entities;
using Ambev.DeveloperEvaluation.Domain.Repositories;
using Ambev.DeveloperEvaluation.ORM.Options;
using MongoDB.Driver;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    public class BranchRepository : Repository<Branch>, IBranchRepository
    {
        private readonly IMongoCollection<Branch> _branchCollection;
        public BranchRepository(DefaultContext context, IMongoDatabaseSettings mongoSettings) : base(context, mongoSettings)
        {
            var client = new MongoClient(mongoSettings.ConnectionString);
            var database = client.GetDatabase(mongoSettings.DatabaseName);

            _branchCollection = database.GetCollection<Branch>(nameof(Branch));
            base.MongoDB(_branchCollection);
        }

        public async Task AddRangeNoSql(IEnumerable<Branch> branches)
        {
            await _mongoContext.InsertManyAsync(branches);
        }
    }
}
