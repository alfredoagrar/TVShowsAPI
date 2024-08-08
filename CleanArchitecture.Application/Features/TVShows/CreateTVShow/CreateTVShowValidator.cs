using FluentValidation;

namespace CleanArchitecture.Application.Features.TVShows.CreateTVShow
{
    /// <summary>
    /// Validator for <see cref="CreateTVShowRequest"/> using FluentValidation.
    /// </summary>
    public sealed class CreateTVShowValidator : AbstractValidator<CreateTVShowRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTVShowValidator"/> class and configures validation rules.
        /// </summary>
        public CreateTVShowValidator()
        {
            // Rule that ensures the Name property is not empty and does not exceed 200 characters.
            RuleFor(x => x.Name)
                .NotEmpty()
                .MaximumLength(200);
        }
    }
}
