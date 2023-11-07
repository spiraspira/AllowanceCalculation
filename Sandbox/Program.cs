using AllowanceCalculation.BLL.DI;
using AllowanceCalculation.BLL.Interfaces;
using AllowanceCalculation.BLL.Mapper;
using AllowanceCalculation.BLL.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

IConfiguration configuration = new ConfigurationBuilder()
	.SetBasePath(Directory.GetCurrentDirectory())
	.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
	.AddEnvironmentVariables()
	.AddCommandLine(args)
	.Build();

var services = new ServiceCollection();

services.AddAutoMapper(typeof(MappingProfile).Assembly, typeof(AllowanceCalculation.BLL.Mapper.MappingProfile).Assembly);

services.AddBusinessLogic(configuration);

var serviceProvider = services.BuildServiceProvider();

var
	repo = (ICommonService<StudentModel>)serviceProvider.GetRequiredService(typeof(ICommonService<StudentModel>));

var student = repo.Get(1).Result; // works

foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(student))
{
	string name = descriptor.Name;
	object? value = descriptor.GetValue(student);
	Console.WriteLine("{0}={1}", name, value);
}

//var newStudent = new StudentModel() { Name = "Тестич Т.Т." , GroupId = 1};

await repo.Delete(9);

//await repo.Create(newStudent); // works

var students = repo.GetAll().Result; // works



Console.WriteLine();