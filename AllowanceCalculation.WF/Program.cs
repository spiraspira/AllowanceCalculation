using AllowanceCalculation.WF.Forms;

namespace AllowanceCalculation.WF;

internal static class Program
{
	private static IConfiguration? _configuration;

	private static IServiceCollection? _services;

	public static IServiceProvider? ServiceProvider;

	private const string ConfigurationFilePath = "appsettings.json";

	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();

		AddConfiguration(out _configuration, ConfigurationFilePath);

		AddServices(out _services, _configuration);

		AddServiceProvider(out ServiceProvider, _services);

		Application.Run(new AuthorizationForm());
	}

	private static void AddConfiguration(out IConfiguration configuration, string configurationFilePath)
	{
		configuration = new ConfigurationBuilder()
			.AddJsonFile(configurationFilePath, optional: true, reloadOnChange: true)
			.Build();
	}

	private static void AddServices(out IServiceCollection services, IConfiguration configuration)
	{
		services = new ServiceCollection();

		services.AddBusinessLogic(configuration);
	}

	private static void AddServiceProvider(out IServiceProvider serviceProvider, IServiceCollection services)
	{
		serviceProvider = services.BuildServiceProvider();
	}
}