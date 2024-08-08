using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Persistence.Context;

namespace CleanArchitecture.Persistence.Repositories;
public class TVShowsRepository : BaseRepository<TvShow>, ITVShowsRepository
{
    public TVShowsRepository(DataContext context) : base(context)
    {
    }

    // Add specifict methods for the tv repositorie
}

