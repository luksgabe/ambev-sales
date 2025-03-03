namespace Ambev.DeveloperEvaluation.Domain.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        /// <summary>
        /// Retrieves a entity by their unique identifier
        /// </summary>
        /// <param name="id">The unique identifier of the entity</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The entity if found, null otherwise</returns>
        Task<TEntity?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get all entities objects of the repository
        /// </summary>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the entity was deleted, false if not found</returns>
        Task<IEnumerable<TEntity?>> GetAll(CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new entity in the repository
        /// </summary>
        /// <param name="entity">The entity to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created entity</returns>
        Task<TEntity> CreateAsync(TEntity entity, CancellationToken cancellationToken = default);

        /// <summary>
        /// Update an object into database
        /// </summary>
        /// <param name="entity">The object to create</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>The created object</returns>
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken = default);
        
        /// <summary>
        /// Deletes a entity from the repository
        /// </summary>
        /// <param name="id">The unique identifier of the entity to delete</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>True if the entity was deleted, false if not found</returns>
        Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);


        Task CreateNoSql(TEntity entity);
        Task UpdateNoSql(Guid id, TEntity entity);
        Task DeleteNoSql(Guid id);
        Task DeleteNoSql(Guid id, TEntity entityForDeletion);
    }
}
