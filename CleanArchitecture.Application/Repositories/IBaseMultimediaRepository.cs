using CleanArchitecture.Domain.Commond;

namespace CleanArchitecture.Application.Repositories
{
    /// <summary>
    /// Defines the contract for a repository that manages multimedia entities.
    /// </summary>
    /// <typeparam name="T">The type of the multimedia entity, which must inherit from <see cref="BaseMultimediaEntity"/>.</typeparam>
    public interface IBaseMultimediaRepository<T> where T : BaseMultimediaEntity
    {
        /// <summary>
        /// Creates a new multimedia entity.
        /// </summary>
        /// <param name="entity">The multimedia entity to create.</param>
        void Create(T entity);

        /// <summary>
        /// Updates an existing multimedia entity.
        /// </summary>
        /// <param name="Id">The unique identifier of the multimedia entity to update.</param>
        /// <param name="entity">The updated multimedia entity.</param>
        /// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
        Task Update(int Id, T entity, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes a multimedia entity by its unique identifier.
        /// 
        /// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
        /// </summary>
        /// <param name="Id">The unique identifier of the multimedia entity to delete.</param>
        Task Delete(int Id, CancellationToken cancellationToken);

        /// <summary>
        /// Retrieves a multimedia entity by its unique identifier.
        /// </summary>
        /// <param name="id">The unique identifier of the multimedia entity to retrieve.</param>
        /// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a result of the multimedia entity.</returns>
        Task<T> Get(int id, CancellationToken cancellationToken);

        /// <summary>
        /// Retrieves all multimedia entities.
        /// </summary>
        /// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation, with a result of a list of multimedia entities.</returns>
        Task<List<T>> GetAll(CancellationToken cancellationToken);
    }
}
