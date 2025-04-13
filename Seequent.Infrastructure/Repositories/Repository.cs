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

    public async Task<TEntity?> GetByIdAsync(long id)
    {
        return await DbSet.FindAsync(id);
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await DbSet.ToListAsync();
    }

    public async Task<TEntity> Add(TEntity entity)
    {
        var tracked = await DbSet.AddAsync(entity);
        await Context.SaveChangesAsync();
        return tracked.Entity;
    }
}
