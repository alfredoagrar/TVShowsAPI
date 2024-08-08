using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Repositories
{
    /// <summary>
    /// Defines the contract for a repository that manages TV show entities.
    /// Inherits from <see cref="IBaseMultimediaRepository{TvShow}"/>.
    /// </summary>
    public interface ITVShowsRepository : IBaseMultimediaRepository<TvShow>
    {
        // Add special methods related to TV shows if needed.
    }
}
