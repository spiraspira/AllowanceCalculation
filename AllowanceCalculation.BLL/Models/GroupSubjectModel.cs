namespace AllowanceCalculation.BLL.Models;

public class GroupSubjectModel
{
	public int Id { get; set; }

	public int GroupId { get; set; }

	public GroupModel? Group { get; set; }

	public int SubjectId { get; set; }

	public SubjectModel? Subject { get; set; }
}