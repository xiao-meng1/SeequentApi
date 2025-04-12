using Microsoft.EntityFrameworkCore;
using Seequent.Core;

namespace Seequent.Infrastructure;
public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
{
    protected readonly SeequentDbContext Context;
    protected readonly DbSet<TEntity> DbSet;

    public Repository(SeequentDbContext context)
    {
        Context = context;
        DbSet = context.Set<TEntity>();
    }

    public async Task<TEntity?> GetById(long id)
    {
        return await DbSet.FindAsync(id);
    }

    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await DbSet.ToListAsync();
    }
}
