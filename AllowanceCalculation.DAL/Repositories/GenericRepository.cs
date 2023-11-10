namespace AllowanceCalculation.DAL.Repositories;

public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : EntityWithId
{
	protected readonly ApplicationContext Context;

	protected readonly DbSet<TEntity> Set;

	public GenericRepository(ApplicationContext dbContext)
	{
		Context = dbContext;

		Set = Context.Set<TEntity>();
	}

	public virtual async Task<IEnumerable<TEntity>> GetAll()
	{
		return await Set.AsNoTracking().ToListAsync();
	}

	public virtual async Task<TEntity?> Get(int id)
	{
		return await Set.AsNoTracking().FirstAsync(a => a.Id == id);
	}

	public async Task<TEntity> Create(TEntity item)
	{
		Set.Add(item);

		await Context.SaveChangesAsync();

		return item;
	}

	public async Task<TEntity?> Update(TEntity item)
	{
		if (item.Id == 0)
		{
			return null;
		}

		Context.Entry(item).State = EntityState.Modified;

		await Context.SaveChangesAsync();

		Context.Entry(item).State = EntityState.Detached;

		return item;
	}

	public async Task Delete(int id)
	{
		var entity = Set.FirstOrDefault(a => a.Id == id);

		if (entity != null)
		{
			Set.Remove(entity);

			await Context.SaveChangesAsync();
		}
	}
}