namespace AllowanceCalculation.DAL.Entities;

public class StudentGrade : EntityWithId
{
	public int? StudentId { get; set; }

	public Student? Student { get; set; }

	public int? SubjectId { get; set; }

	public Subject? Subject { get; set; }

	public int? Grade { get; set; }
}