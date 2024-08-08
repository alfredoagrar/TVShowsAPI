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

    public void Update(int Id, TEntity entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(int Id)
    {
        throw new NotImplementedException();
    }
}