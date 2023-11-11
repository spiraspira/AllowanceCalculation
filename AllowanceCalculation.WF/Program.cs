namespace AllowanceCalculation.WF;

internal static class Program
{
	private static IConfiguration? _configuration;

	private static IServiceCollection? _services;

	private static IServiceProvider? _serviceProvider;

	private const string ConfigurationFilePath = "appsettings.json";

	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();

		_configuration = GetConfiguration(ConfigurationFilePath);

		_services = GetServices(_configuration);

		_serviceProvider = GetServiceProvider(_services);

		Application.Run(new AuthorizationForm(_serviceProvider, _configuration));
	}

	private static IConfiguration GetConfiguration(string configurationFilePath)
	{
		return new ConfigurationBuilder()
			.AddJsonFile(configurationFilePath, optional: true, reloadOnChange: true)
			.Build();
	}

	private static IServiceCollection GetServices(IConfiguration configuration)
	{
		var services = new ServiceCollection();

		services.AddBusinessLogic(configuration);

		return services;
	}

	private static IServiceProvider GetServiceProvider(IServiceCollection services)
	{
		return services.BuildServiceProvider();
	}
}