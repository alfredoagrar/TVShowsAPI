using MediatR;

namespace CleanArchitecture.Application.Features.TVShows.UpdateTVShows
{
    public sealed record class UpdateTVShowRequest(int Id, string Name, bool Favorite) : IRequest<UpdateTVShowResponse>;
}
