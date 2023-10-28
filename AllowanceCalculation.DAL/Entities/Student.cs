namespace AllowanceCalculation.DAL.Entities
{
	public class Student : EntityWithId
	{
		public string? Name { get; set; }

		public bool? IsOnBudget { get; set; }

		public bool? IsSocialWorkActive { get; set; }

		public int GroupId { get; set; }

		public Group? Group { get; set; }

		public List<StudentGrade> StudentGrades { get; set; } = new List<StudentGrade>();
	}
}
