
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

        var tvShows = Enumerable.Range(1, 100).Select(i => new TvShow
        {
            Id = i,
            Name = $"TvShow {i}",
            Favorite = i % 2 == 0 // Alterna entre verdadero y falso
        }).ToArray();

        modelBuilder.Entity<TvShow>().HasData(tvShows);
    }
}