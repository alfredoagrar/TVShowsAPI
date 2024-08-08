using CleanArchitecture.Application.Features.TVShows.UpdateTVShows;
using FluentValidation;

namespace CleanArchitecture.Application.Features.TVShows.UpdateTVShow
{
    public sealed class DeleteTVShowShowsValidator : AbstractValidator<UpdateTVShowRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTVShowValidator"/> class and configures validation rules.
        /// </summary>
        public DeleteTVShowShowsValidator()
        {
            // Rule that ensures the Name property is not empty and does not exceed 200 characters.
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(200);
        }
    }
}
