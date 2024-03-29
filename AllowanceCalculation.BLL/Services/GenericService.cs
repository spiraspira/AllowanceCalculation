﻿namespace AllowanceCalculation.BLL.Services;

public class GenericService<TModel, TEntity> : IGenericService<TModel>
	where TEntity : EntityWithId
	where TModel : class
{
	protected readonly IRepository<TEntity> _repository;

	protected readonly IMapper _mapper;

	public GenericService(IRepository<TEntity> repository, IMapper mapper)
	{
		_repository = repository;

		_mapper = mapper;
	}

	public async Task<TModel> Create(TModel model)
	{
		var entity = _mapper.Map<TEntity>(model);

		return _mapper.Map<TModel>(await _repository.Create(entity));
	}

	public async Task Delete(int id)
	{
		await _repository.Delete(id);
	}

	public async Task<TModel> Get(int id)
	{
		return _mapper.Map<TModel>(await _repository.Get(id));
	}

	public async Task<IEnumerable<TModel>> GetAll()
	{
		return _mapper.Map<IEnumerable<TModel>>(await _repository.GetAll());
	}

	public async Task<TModel> Update(TModel model)
	{
		var entity = _mapper.Map<TEntity>(model);

		return _mapper.Map<TModel>(await _repository.Update(entity));
	}
}