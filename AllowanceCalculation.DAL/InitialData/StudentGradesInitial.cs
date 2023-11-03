namespace AllowanceCalculation.DAL.InitialData;

public class StudentGradesInitial
{
	public static readonly StudentGrade[]
		StudentGrades =
		{
			new() { Id = 1, StudentId = 1, SubjectId = 1, Grade = 10},
			new() { Id = 2, StudentId = 1, SubjectId = 1, Grade = 10},
			new() { Id = 3, StudentId = 2, SubjectId = 1, Grade = 10},
			new() { Id = 4, StudentId = 2, SubjectId = 1, Grade = 10},
			new() { Id = 5, StudentId = 3, SubjectId = 1, Grade = 10},
			new() { Id = 6, StudentId = 3, SubjectId = 1, Grade = 10},
			new() { Id = 7, StudentId = 4, SubjectId = 1, Grade = 10},
			new() { Id = 8, StudentId = 5, SubjectId = 1, Grade = 10},
			new() { Id = 10, StudentId = 6, SubjectId = 4, Grade = 10},
			new() { Id = 11, StudentId = 7, SubjectId = 4, Grade = 0},
		};
}