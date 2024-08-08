using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.TVShows.UpdateTVShows
{
    public sealed class UpdateTVShowMapper : Profile
    {
        public UpdateTVShowMapper()
        {
            // Maps from TvShow to GetAllTVShowsResponse
            CreateMap<UpdateTVShowRequest, TvShow>();
            CreateMap<TvShow, UpdateTVShowResponse>();
        }
    }
}
