using AutoMapper;
using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Entities;
using MediatR;

namespace CleanArchitecture.Application.Features.TVShows.UpdateTVShows
{
    internal class UpdateTVShowHandler : IRequestHandler<UpdateTVShowRequest, UpdateTVShowResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ITVShowsRepository _tvShowsRepository;
        private readonly IMapper _mapper;

        public UpdateTVShowHandler(IUnitOfWork UnitOfWork, ITVShowsRepository tvShowsRepository, IMapper mapper)
        {
            _unitOfWork = UnitOfWork;
            _tvShowsRepository = tvShowsRepository;
            _mapper = mapper;
        }

        public async Task<UpdateTVShowResponse> Handle(UpdateTVShowRequest request, CancellationToken cancellationToken)
        {
            // Map the request to a TvShow entity
            var tvshow = _mapper.Map<TvShow>(request);

            // Create the TV show entity in the repository
            _tvShowsRepository.Update(tvshow.Id, tvshow, cancellationToken);
            // Save changes in the unit of work
            await _unitOfWork.Save(cancellationToken);

            // Map the created TvShow entity to a response
            return _mapper.Map<UpdateTVShowResponse>(tvshow);
        }
    }
}
