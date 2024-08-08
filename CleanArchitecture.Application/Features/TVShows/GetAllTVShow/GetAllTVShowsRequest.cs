using MediatR;

namespace CleanArchitecture.Application.Features.TVShows.GetAllTVShows
{
    /// <summary>
    /// Represents a request to retrieve all TV shows.
    /// Implements <see cref="IRequest{List{GetAllTVShowsResponse}}"/>.
    /// </summary>
    public sealed record class GetAllTVShowsRequest : IRequest<List<GetAllTVShowsResponse>>;
}
