namespace AllowanceCalculation.BLL.Models;

public class StudentModel
{
	public int Id { get; set; }

	public string? Name { get; set; }

	public bool? IsOnBudget { get; set; }

	public bool? IsSocialWorkActive { get; set; }

	public int GroupId { get; set; }

	public GroupModel? Group { get; set; }

	public List<StudentGradeModel> StudentGrades { get; set; } = new();
}