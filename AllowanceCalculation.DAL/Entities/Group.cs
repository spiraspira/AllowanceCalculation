namespace AllowanceCalculation.DAL.Entities;

public class Group : EntityWithId
{
	public string? Name { get; set; }

	public List<Student> Students { get; set; } = new();

	public List<GroupSubject> GroupSubjects { get; set; } = new();
}