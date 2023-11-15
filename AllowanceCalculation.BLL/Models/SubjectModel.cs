namespace AllowanceCalculation.BLL.Models;

public class SubjectModel
{
	public int Id { get; set; }

	public string? Name { get; set; }

	public bool? IsPassFailEvaluated { get; set; }

	public List<GroupSubjectModel> GroupSubjects { get; set; } = new List<GroupSubjectModel>();

	public List<StudentGradeModel> StudentGrades { get; set; } = new List<StudentGradeModel>();
}