using AutoMapper;
using CleanArchitecture.Application.Repositories;
using MediatR;

namespace CleanArchitecture.Application.Features.TVShows.GetAllTVShows
{
    /// <summary>
    /// Handles the retrieval of all TV shows by implementing the <see cref="IRequestHandler{GetAllTVShowsRequest, List{GetAllTVShowsResponse}}"/> interface.
    /// </summary>
    internal class GetAllTVShowsHandler : IRequestHandler<GetAllTVShowsRequest, List<GetAllTVShowsResponse>>
    {
        private readonly ITVShowsRepository _tvShowsRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetAllTVShowsHandler"/> class.
        /// </summary>
        /// <param name="tvShowsRepository">The repository used to retrieve TV show entities.</param>
        /// <param name="mapper">The AutoMapper instance used to map between TV show entities and response objects.</param>
        public GetAllTVShowsHandler(ITVShowsRepository tvShowsRepository, IMapper mapper)
        {
            _tvShowsRepository = tvShowsRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the request to retrieve all TV shows.
        /// </summary>
        /// <param name="request">The request to retrieve all TV shows.</param>
        /// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
        /// <returns>A <see cref="Task{List{GetAllTVShowsResponse}}"/> representing the asynchronous operation, with a result of the list of TV show responses.</returns>
        public async Task<List<GetAllTVShowsResponse>> Handle(GetAllTVShowsRequest request, CancellationToken cancellationToken)
        {
            // Retrieve all TV show entities from the repository
            var tvShows = await _tvShowsRepository.GetAll(cancellationToken);

            // Map the TV show entities to a list of response objects
            return _mapper.Map<List<GetAllTVShowsResponse>>(tvShows);
        }
    }
}
