using CleanArchitecture.Application.Features.TVShows.CreateTVShow;
using CleanArchitecture.Application.Features.TVShows.GetAllTVShows;
using CleanArchitecture.Application.Features.TVShows.UpdateTVShows;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace tvshows.api.Controllers;

[ApiController]
[Route("controllers")]
public class TVShowsController: ControllerBase
{
    private readonly IMediator _mediator;

    public TVShowsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<CreateTVShowResponse>> Create(
        CreateTVShowRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<List<GetAllTVShowsResponse>>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllTVShowsRequest(), cancellationToken);
        return Ok(response);
    }


    [HttpPut]
    public async Task<ActionResult<UpdateTVShowResponse>> Update(
        UpdateTVShowRequest request,
        CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}
