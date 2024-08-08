namespace CleanArchitecture.Domain.Commond
{
    /// <summary>
    /// Represents a base multimedia entity with common properties.
    /// </summary>
    public abstract class BaseMultimediaEntity
    {
        /// <summary>
        /// Gets or sets the unique identifier of the entity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the multimedia entity.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the multimedia entity is marked as favorite.
        /// </summary>
        public bool Favorite { get; set; }
    }
}
