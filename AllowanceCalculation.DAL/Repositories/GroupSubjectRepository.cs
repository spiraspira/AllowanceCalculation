namespace AllowanceCalculation.DAL.Repositories;

public class GroupSubjectRepository : GenericRepository<GroupSubject>
{
	public GroupSubjectRepository(ApplicationContext dbContext) : base(dbContext)
	{

	}

	public override async Task<GroupSubject?> Get(int id)
	{
		return await Set
			.Include(g => g.Group)
			.Include(g => g.Subject)
			.FirstOrDefaultAsync(g => g.Id == id);
	}

	public override async Task<IEnumerable<GroupSubject>> GetAll()
	{
		return await Set
			.Include(g => g.Group)
			.Include(g => g.Subject)
			.ToListAsync();
	}
}