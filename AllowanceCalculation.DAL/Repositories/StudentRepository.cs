namespace AllowanceCalculation.DAL.Repositories;

public class StudentRepository : GenericRepository<Student>
{
	public StudentRepository(ApplicationContext dbContext) : base(dbContext)
	{

	}

	public override async Task<Student?> Get(int id)
	{
		return await Set
			.AsNoTracking()
			.Include(s => s.StudentGrades)
			.Include(s => s.Group)
			.FirstOrDefaultAsync(g => g.Id == id);
	}

	public override async Task<IEnumerable<Student>> GetAll()
	{
		return await Set
			.AsNoTracking()
			.Include(s => s.StudentGrades)
			.Include(s => s.Group)
			.ToListAsync();
	}
}