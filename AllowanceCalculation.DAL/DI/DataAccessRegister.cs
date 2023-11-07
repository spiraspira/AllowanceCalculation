namespace AllowanceCalculation.DAL.DI;

public static class DataAccessRegister
{
	public static void AddDataAccess(this IServiceCollection services, IConfiguration config)
	{
		services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

		services.AddScoped<IRepository<Group>, GroupRepository>();

		services.AddScoped<IRepository<GroupSubject>, GroupSubjectRepository>();

		services.AddScoped<IRepository<Student>, StudentRepository>();

		services.AddScoped<IRepository<StudentGrade>, StudentGradeRepository>();

		services.AddScoped<IRepository<Subject>, SubjectRepository>();

		services.AddDbContext<ApplicationContext>(op =>
			{
				op.UseNpgsql(config.GetConnectionString("DefaultConnection"));
			}
		);
	}
}