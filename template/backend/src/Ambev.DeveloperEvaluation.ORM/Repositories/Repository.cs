using Ambev.DeveloperEvaluation.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ambev.DeveloperEvaluation.ORM.Repositories
{
    /// <summary>
    /// Implementation of generic class Repository using Entity Framework Core
    /// </summary>
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DefaultContext _context;

        /// <summary>
        /// Initializes a new instance of Repository
        /// </summary>
        /// <param name="context">The database context</param>
        protected Repository(DefaultContext context)
        {
            _context = context;
            _context.ChangeTracker.LazyLoadingEnabled = false;
        }

        private DbSet<TEntity> _dbSet => _context.Set<TEntity>();

        /// <summary>
        /// Retrieves a list of objects
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The object if found, null otherwise</returns>
        public async Task<IEnumerable<TEntity?>> GetAll(CancellationToken cancellationToken = default)
        {
            return await _dbSet.ToListAsync(cancellationToken);
        }

        /// <summary>
        /// Retrieves a object by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the object</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The object if found, null otherwise</returns>
        public async Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _dbSet.FindAsync(id, cancellationToken);
        }


        /// <summary>
        /// Creates a new object in the database
        /// </summary>
        /// <param name="entity">The object to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created object</returns>
        public async Task<TEntity> CreateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            await _dbSet.AddAsync(entity, cancellationToken);
            return entity;
        }

        /// <summary>
        /// Update an object into database
        /// </summary>
        /// <param name="entity">The object to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created object</returns>
        public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default)
        {
            await Task.FromResult(_dbSet.Update(entity));
            return entity;
        }

        /// <summary>
        /// Deletes a object from the database
        /// </summary>
        /// <param name="id">The unique identifier of the object to delete</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the object was deleted, false if not found</returns>
        public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            var entity = await GetByIdAsync(id, cancellationToken);
            if (entity == null)
                return false;

            _dbSet.Remove(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        /// <summary>
        /// Release the alocated resources by the context
        /// </summary>
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
