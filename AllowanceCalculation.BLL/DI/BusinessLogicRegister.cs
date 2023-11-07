namespace AllowanceCalculation.BLL.DI;

public static class BusinessLogicRegister
{
	public static void AddBusinessLogic(this IServiceCollection services, IConfiguration config)
	{
		services.AddScoped(
			typeof(ICommonService<GroupModel>), 
			typeof(CommonService<GroupModel, Group>));

		services.AddScoped(
			typeof(ICommonService<GroupSubjectModel>),
			typeof(CommonService<GroupSubjectModel, GroupSubject>));

		services.AddScoped(
			typeof(ICommonService<StudentModel>), 
			typeof(CommonService<StudentModel, Student>));

		services.AddScoped(
			typeof(ICommonService<StudentGradeModel>),
			typeof(CommonService<StudentGradeModel, StudentGrade>));

		services.AddScoped(
			typeof(ICommonService<SubjectModel>),
			typeof(CommonService<SubjectModel, Subject>));

		services.AddScoped(
			typeof(IAllowanceCalculationService),
			typeof(AllowanceCalculationService));

		services.AddDataAccess(config);
	}
}