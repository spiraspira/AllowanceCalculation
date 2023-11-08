namespace AllowanceCalculation.BLL.DI;

public static class BusinessLogicRegister
{
	public static void AddBusinessLogic(this IServiceCollection services, IConfiguration config)
	{
		services.AddAutoMapper(typeof(MappingProfile).Assembly, typeof(MappingProfile).Assembly);

		services.AddScoped<IGenericService<GroupModel>, GenericService<GroupModel, Group>>();

		services.AddScoped<IGenericService<GroupSubjectModel>, GenericService<GroupSubjectModel, GroupSubject>>();

		services.AddScoped<IGenericService<StudentModel>, GenericService<StudentModel, Student>>();

		services.AddScoped<IGenericService<StudentGradeModel>, GenericService<StudentGradeModel, StudentGrade>>();

		services.AddScoped<IGenericService<SubjectModel>, GenericService<SubjectModel, Subject>>();

		services.AddScoped<IAllowanceCalculationService, AllowanceCalculationService>();

		services.AddDataAccess(config);
	}
}