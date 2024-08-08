namespace CleanArchitecture.Application.Features.TVShows.GetAllTVShows
{
    /// <summary>
    /// Represents the response for retrieving a TV show.
    /// </summary>
    public sealed record GetAllTVShowsResponse
    {
        /// <summary>
        /// Gets or sets the unique identifier of the TV show.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name of the TV show.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether the TV show is marked as a favorite.
        /// </summary>
        public bool Favorite { get; set; }
    }
}
