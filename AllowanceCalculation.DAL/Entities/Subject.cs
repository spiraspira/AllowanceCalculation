namespace AllowanceCalculation.DAL.Entities
{
	public class Subject : EntityWithId
	{
		public string? Name { get; set; }

		public bool? IsPassFailEvaluated { get; set; }

		public List<Group> Groups { get; set; } = new List<Group>();

		public List<StudentGrade> StudentGrades { get; set; } = new List<StudentGrade>();
	}
}
