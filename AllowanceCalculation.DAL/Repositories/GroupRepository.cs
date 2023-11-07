namespace AllowanceCalculation.DAL.Repositories;

public class GroupRepository : GenericRepository<Group>
{
	public GroupRepository(ApplicationContext dbContext) : base(dbContext)
	{

	}

	public override async Task<Group?> Get(int id)
	{
		return await Set
			.AsNoTracking()
			.Include(g => g.GroupSubjects)
			.Include(g => g.Students)
			.FirstOrDefaultAsync(g => g.Id == id);
	}

	public override async Task<IEnumerable<Group>> GetAll()
	{
		return await Set
			.AsNoTracking()
			.Include(g => g.GroupSubjects)
			.Include(g => g.Students)
			.ToListAsync();
	}
}