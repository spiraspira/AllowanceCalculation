namespace AllowanceCalculation.DAL.Repositories;

public class StudentGradeRepository : GenericRepository<StudentGrade>
{
	public StudentGradeRepository(ApplicationContext dbContext) : base(dbContext)
	{

	}

	public override async Task<StudentGrade?> Get(int id)
	{
		return await Set
			.Include(s => s.Subject)
			.Include(s => s.Student)
			.FirstOrDefaultAsync(g => g.Id == id);
	}

	public override async Task<IEnumerable<StudentGrade>> GetAll()
	{
		return await Set
			.Include(s => s.Subject)
			.Include(s => s.Student)
			.ToListAsync();
	}
}