namespace CleanArchitecture.Application.Features.TVShows.CreateTVShow
{
    /// <summary>
    /// Represents the response for a successful TV show creation request.
    /// </summary>
    public sealed record CreateTVShowResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier of the created TV show.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the created TV show.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the TV show is marked as a favorite.
        /// </summary>
        public bool Favorite { get; set; }
    }
}
