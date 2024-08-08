using MediatR;

namespace CleanArchitecture.Application.Features.TVShows.CreateTVShow
{
    /// <summary>
    /// Represents a request to create a new TV show.
    /// Implements <see cref="IRequest{CreateTVShowResponse}"/>.
    /// </summary>
    /// <param name="Name">The name of the TV show to be created.</param>
    public sealed record CreateTVShowRequest(string Name) : IRequest<CreateTVShowResponse>;
}
