using AutoMapper;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.TVShows.CreateTVShow
{
    /// <summary>
    /// Handles the creation of a new TV show by implementing the <see cref="IRequestHandler{CreateTVShowRequest, CreateTVShowResponse}"/> interface.
    /// </summary>
    public sealed class CreateTVShowHandler : IRequestHandler<CreateTVShowRequest, CreateTVShowResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITVShowsRepository _tvShowsRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTVShowHandler"/> class.
        /// </summary>
        /// <param name="unitOfWork">The unit of work used to commit changes to the database.</param>
        /// <param name="tvShowsRepository">The repository used to manage TV show entities.</param>
        /// <param name="mapper">The AutoMapper instance used to map between request and entity objects.</param>
        public CreateTVShowHandler(IUnitOfWork unitOfWork, ITVShowsRepository tvShowsRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _tvShowsRepository = tvShowsRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Handles the creation of a new TV show.
        /// </summary>
        /// <param name="request">The request containing the details of the TV show to create.</param>
        /// <param name="cancellationToken">A cancellation token to observe while waiting for the task to complete.</param>
        /// <returns>A <see cref="Task{CreateTVShowResponse}"/> representing the asynchronous operation, with a result of the created TV show response.</returns>
        public async Task<CreateTVShowResponse> Handle(CreateTVShowRequest request, CancellationToken cancellationToken)
        {
            // Map the request to a TvShow entity
            var tvshow = _mapper.Map<TvShow>(request);

            // Create the TV show entity in the repository
            _tvShowsRepository.Create(tvshow);

            // Save changes in the unit of work
            await _unitOfWork.Save(cancellationToken);

            // Map the created TvShow entity to a response
            return _mapper.Map<CreateTVShowResponse>(tvshow);
        }
    }
}
