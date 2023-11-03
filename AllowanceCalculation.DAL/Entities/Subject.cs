namespace AllowanceCalculation.DAL.Entities;

public class Subject : EntityWithId
{
	public string? Name { get; set; }

	public bool? IsPassFailEvaluated { get; set; }

	public List<GroupSubject> GroupSubjects { get; set; } = new List<GroupSubject>();

	public List<StudentGrade> StudentGrades { get; set; } = new List<StudentGrade>();
}