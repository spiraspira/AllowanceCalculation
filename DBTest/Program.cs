using AllowanceCalculation.DAL.Entities;
using AllowanceCalculation.DAL.Repositories;

using (var context = new ApplicationContext())
{
	var repository = new StudentRepository(context);

	var students = repository.GetAll().Result;

	var student = repository.Get(1).Result;

	Console.WriteLine();
}