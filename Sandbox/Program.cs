using AllowanceCalculation.BLL.DI;
using AllowanceCalculation.BLL.Interfaces;
using AllowanceCalculation.BLL.Mapper;
using AllowanceCalculation.BLL.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AllowanceCalculation.BLL.Extensions;
using static System.String;

IConfiguration configuration = new ConfigurationBuilder()
	.SetBasePath(Directory.GetCurrentDirectory())
	.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
	.AddEnvironmentVariables()
	.AddCommandLine(args)
	.Build();

var services = new ServiceCollection();

services.AddAutoMapper(typeof(MappingProfile).Assembly, typeof(MappingProfile).Assembly);

services.AddBusinessLogic(configuration);

var serviceProvider = services.BuildServiceProvider();

var
	repo = (ICommonService<StudentModel>)serviceProvider.GetRequiredService(typeof(ICommonService<StudentModel>));

var
	caltulationService =
		(IAllowanceCalculationService)serviceProvider.GetRequiredService(typeof(IAllowanceCalculationService));

//var student = repo.Get(1).Result; // works

//foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(student))
//{
//	string name = descriptor.Name;
//	object? value = descriptor.GetValue(student);
//	Console.WriteLine("{0}={1}", name, value);
//}

//var newStudent = new StudentModel() { Name = "Тестич Т.Т." , GroupId = 1};

//await repo.Delete(9); //works

//await repo.Create(newStudent); // works

var students = repo.GetAll().Result; // works

//student.Name = "Заборонок Ж.Ж.";

//await repo.Update(student);

Console.WriteLine($"" +
                  $"{"Name",20}|" +
                  $"{"Grades",30}|" +
                  $"{"On budged",11}|" +
                  $"{"Social work",11}|" +
                  $"Allowance");

foreach (var elem in students)
{
	Console.WriteLine($"" +
	                  $"{elem.Name, 20}|" +
	                  $"{Join(' ', elem.GetGrades().ToArray()), 30}|" +
	                  $"{elem.IsOnBudget, 11}|" +
	                  $"{elem.IsSocialWorkActive, 11}|" +
	                  $"{caltulationService.GetAllowance(elem.Id, 50):C}");
}

Console.WriteLine();