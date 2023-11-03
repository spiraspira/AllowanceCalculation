namespace AllowanceCalculation.DAL.Entities;

public class ApplicationContext : DbContext
{
	private const string
		ConnectionString = "host=localhost; port=5432; database=AllowanceCalculation; username=postgres; password=1111";

	public DbSet<Group>? Groups { get; set; }

	public DbSet<GroupSubject> GroupSubjects { get; set; }

	public DbSet<Subject>? Subjects { get; set; }

	public DbSet<Student>? Students { get; set; }

	public DbSet<StudentGrade>? StudentGrades { get; set; }

	public ApplicationContext()
	{
		Database.EnsureDeleted();

		Database.EnsureCreated();
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseNpgsql(ConnectionString);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Group>(a => a.HasData(GroupInitial.Groups));

		modelBuilder.Entity<GroupSubject>(a => a.HasData(GroupSubjectInitial.GroupSubjects));

		modelBuilder.Entity<Subject>(a => a.HasData(SubjectInitial.Subjects));

		modelBuilder.Entity<Student>(a => a.HasData(StudentInitial.Students));

		modelBuilder.Entity<StudentGrade>(a => a.HasData(StudentGradesInitial.StudentGrades));
	}
}