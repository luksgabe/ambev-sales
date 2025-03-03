using Ambev.DeveloperEvaluation.Domain.SeedWork;
using System;

namespace Ambev.DeveloperEvaluation.ORM
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DefaultContext _context;

        public UnitOfWork(DefaultContext context)
        {
            _context = context;
        }

        public async Task<int> CommitAsync(CancellationToken cancellationToken = default(CancellationToken))
        {
            return await this._context.SaveChangesAsync(cancellationToken);
        }
    }
}
