namespace AllowanceCalculation.DAL.Repositories;

public class SubjectRepository : GenericRepository<Subject>
{
	public SubjectRepository(ApplicationContext dbContext) : base(dbContext)
	{

	}

	public override async Task<Subject?> Get(int id)
	{
		return await Set
			.Include(s => s.StudentGrades)
			.Include(s => s.GroupSubjects)
			.FirstOrDefaultAsync(g => g.Id == id);
	}

	public override async Task<IEnumerable<Subject>> GetAll()
	{
		return await Set
			.Include(s => s.StudentGrades)
			.Include(s => s.GroupSubjects)
			.ToListAsync();
	}
}