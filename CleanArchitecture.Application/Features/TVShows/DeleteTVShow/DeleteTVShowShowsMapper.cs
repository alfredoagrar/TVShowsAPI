using AutoMapper;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Features.TVShows.DeleteTVShowShows
{
    public sealed class DeleteTVShowShowsMapper : Profile
    {
        public DeleteTVShowShowsMapper()
        {
            // Maps from TvShow to GetAllTVShowsResponse
            CreateMap<DeleteTVShowShowsRequest, TvShow>();
            CreateMap<TvShow, DeleteTVShowShowsResponse>();
        }
    }
}
