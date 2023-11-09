namespace AllowanceCalculation.WF.Extensions;

public static class ServiceProviderExtension
{
	public static async Task<IEnumerable<T>> GetTableAsync<T>(this IServiceProvider serviceProvider) where T : class
	{
		var genericService = (IGenericService<T>)serviceProvider
			.GetRequiredService(typeof(IGenericService<T>));

		return await genericService.GetAll();
	}

	public static async Task<T> GetRecordAsync<T>(this IServiceProvider serviceProvider, int id) where T : class
	{
		var genericService = (IGenericService<T>)serviceProvider
			.GetRequiredService(typeof(IGenericService<T>));

		return await genericService.Get(id);
	}

	public static async Task<double> GetAllowance(this IServiceProvider serviceProvider, int id, double allowanceBase)
	{
		var allowanceCalculationService = serviceProvider.GetRequiredService<IAllowanceCalculationService>();

		return await allowanceCalculationService.GetAllowance(id, allowanceBase);
	}
}