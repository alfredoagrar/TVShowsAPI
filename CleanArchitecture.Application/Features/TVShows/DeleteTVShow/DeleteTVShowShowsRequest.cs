using MediatR;

namespace CleanArchitecture.Application.Features.TVShows.DeleteTVShowShows
{
    public sealed record class DeleteTVShowShowsRequest(int Id) : IRequest<DeleteTVShowShowsResponse>;
}
