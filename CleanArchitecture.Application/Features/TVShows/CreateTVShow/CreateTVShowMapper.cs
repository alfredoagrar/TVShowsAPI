using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.TVShows.CreateTVShow
{
    /// <summary>
    /// Defines the AutoMapper profile for mapping between <see cref="CreateTVShowRequest"/>, <see cref="TvShow"/>, and <see cref="CreateTVShowResponse"/>.
    /// </summary>
    public sealed class CreateTVShowMapper : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTVShowMapper"/> class and configures the mappings.
        /// </summary>
        public CreateTVShowMapper()
        {
            // Maps from CreateTVShowRequest to TvShow
            CreateMap<CreateTVShowRequest, TvShow>();
            // Maps from TvShow to CreateTVShowResponse
            CreateMap<TvShow, CreateTVShowResponse>();
        }
    }
}
