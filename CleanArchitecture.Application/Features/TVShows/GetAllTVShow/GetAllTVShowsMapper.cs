using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.TVShows.GetAllTVShows
{
    /// <summary>
    /// Defines the AutoMapper profile for mapping between <see cref="TvShow"/> and <see cref="GetAllTVShowsResponse"/>.
    /// </summary>
    public sealed class GetAllTVShowsMapper : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllTVShowsMapper"/> class and configures the mapping rules.
        /// </summary>
        public GetAllTVShowsMapper()
        {
            // Maps from TvShow to GetAllTVShowsResponse
            CreateMap<TvShow, GetAllTVShowsResponse>();
        }
    }
}
