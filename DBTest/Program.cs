using AllowanceCalculation.DAL.DI;
using AllowanceCalculation.DAL.Entities;
using AllowanceCalculation.DAL.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

IConfiguration configuration = new ConfigurationBuilder()
	.SetBasePath(Directory.GetCurrentDirectory())
	.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
	.AddEnvironmentVariables()
	.AddCommandLine(args)
	.Build();

var services = new ServiceCollection();

services.AddDataAccess(configuration);

var context = services.BuildServiceProvider().GetRequiredService<ApplicationContext>();

using (context)
{
	var repository = new StudentRepository(context);

	var students = repository.GetAll().Result;

	var student = repository.Get(1).Result;

	Console.WriteLine();
}