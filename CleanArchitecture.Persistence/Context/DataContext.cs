
using CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Context;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<TvShow> TVShows { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<TvShow>().HasData(
            new TvShow
            {
                Id = 1,
                Name = "Breaking Bad",
                Favorite = true
            },
            new TvShow
            {
                Id = 2,
                Name = "Game of Thrones",
                Favorite = false
            },
            new TvShow
            {
                Id = 3,
                Name = "Stranger Things",
                Favorite = true
            }
        );
    }
}