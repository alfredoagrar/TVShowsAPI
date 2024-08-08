using CleanArchitecture.Application.Repositories;
using CleanArchitecture.Domain.Commond;
using CleanArchitecture.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistence.Repositories;

public class BaseRepository<TEntity> : IBaseMultimediaRepository<TEntity> where TEntity : BaseMultimediaEntity
{
    protected readonly DataContext Context;

    public BaseRepository(DataContext context)
    {
        Context = context;
    }

    public void Create(TEntity entity)
    {
        Context.Add(entity);
    }

    public Task<TEntity> Get(int id, CancellationToken cancellationToken)
    {
        return Context.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public Task<List<TEntity>> GetAll(CancellationToken cancellationToken)
    {
        return Context.Set<TEntity>().ToListAsync(cancellationToken);
    }

    public async Task Update(int id, TEntity entity, CancellationToken cancellationToken)
    {
        var existingEntity = await Context.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        if (existingEntity != null)
        {
            Context.Entry(existingEntity).CurrentValues.SetValues(entity);
            await Context.SaveChangesAsync(cancellationToken);
        }
    }

    public async Task Delete(int id, CancellationToken cancellationToken)
    {
        var entity = await Context.Set<TEntity>().FindAsync(new object[] { id }, cancellationToken);

        if (entity != null)
        {
            Context.Set<TEntity>().Remove(entity);
            await Context.SaveChangesAsync(cancellationToken);
        }
    }
}