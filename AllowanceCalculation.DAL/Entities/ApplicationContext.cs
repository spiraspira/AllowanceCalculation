using Microsoft.EntityFrameworkCore;

namespace AllowanceCalculation.DAL.Entities
{
	public class ApplicationContext : DbContext
	{
		private const string
			ConnectionString = @"host=localhost;port=5432;database=AllowanceCalculation;username=postgres;password=1111";

		public ApplicationContext()
		{
			Database.EnsureCreated();
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(ConnectionString);
		}

		public DbSet<Group> Groups { get; set; }

		public DbSet<Subject> Subjects { get; set; }

		public DbSet<Student> Students { get; set; }

		public DbSet<StudentGrade> StudentGrades { get; set;}
	}
}
