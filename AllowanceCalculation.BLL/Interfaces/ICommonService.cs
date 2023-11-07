namespace AllowanceCalculation.BLL.Interfaces;

public interface ICommonService<TModel> where TModel : class
{
	Task<TModel> Create(TModel model);

	Task<IEnumerable<TModel>> GetAll();

	Task<TModel> Get(int id);

	Task<TModel> Update(TModel model);

	Task Delete(int id);
}