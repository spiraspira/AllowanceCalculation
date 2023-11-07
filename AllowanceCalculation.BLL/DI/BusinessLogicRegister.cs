namespace AllowanceCalculation.BLL.DI;

public static class BusinessLogicRegister
{
	public static void AddBusinessLogic(this IServiceCollection services, IConfiguration config)
	{
		services.AddAutoMapper(typeof(MappingProfile).Assembly, typeof(MappingProfile).Assembly);

		services.AddScoped<ICommonService<GroupModel>, CommonService<GroupModel, Group>>();

		services.AddScoped<ICommonService<GroupSubjectModel>, CommonService<GroupSubjectModel, GroupSubject>>();

		services.AddScoped<ICommonService<StudentModel>, CommonService<StudentModel, Student>>();

		services.AddScoped<ICommonService<StudentGradeModel>, CommonService<StudentGradeModel, StudentGrade>>();

		services.AddScoped<ICommonService<SubjectModel>, CommonService<SubjectModel, Subject>>();

		services.AddScoped<IAllowanceCalculationService, AllowanceCalculationService>();

		services.AddDataAccess(config);
	}
}