namespace AllowanceCalculation.BLL.Models;

public class StudentGradeModel
{
	public int Id { get; set; }

	public int StudentId { get; set; }

	public StudentModel? Student { get; set; }

	public int SubjectId { get; set; }

	public SubjectModel? Subject { get; set; }

	public int? Grade { get; set; }
}