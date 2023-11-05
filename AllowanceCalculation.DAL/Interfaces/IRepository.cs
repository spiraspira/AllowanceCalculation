namespace AllowanceCalculation.DAL.Interfaces;

public interface IRepository<TEntity> where TEntity : EntityWithId
{
	Task<IEnumerable<TEntity>> GetAll();

	Task<TEntity?> Get(int id);

	Task<TEntity> Create(TEntity item);

	Task<TEntity?> Update(TEntity item);

	Task Delete(int id);
}