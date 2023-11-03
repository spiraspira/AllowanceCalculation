namespace AllowanceCalculation.DAL.InitialData;

public class GroupSubjectInitial
{
	public static readonly GroupSubject[]
		GroupSubjects =
		{
			new() {Id = 1, GroupId = 1, SubjectId = 1},
			new() {Id = 2, GroupId = 1, SubjectId = 2},
			new() {Id = 3, GroupId = 2, SubjectId = 1},
			new() {Id = 4, GroupId = 2, SubjectId = 3},
			new() {Id = 5, GroupId = 3, SubjectId = 4},
		};
}