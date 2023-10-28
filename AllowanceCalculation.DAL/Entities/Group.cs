namespace AllowanceCalculation.DAL.Entities
{
    public class Group : EntityWithId
	{
		public string? Name { get; set; }

		public List<Student> Students { get; set; } = new List<Student>();

		public List<Subject> Subjects { get; set; } = new List<Subject>();
	}
}
