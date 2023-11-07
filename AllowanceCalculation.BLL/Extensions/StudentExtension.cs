namespace AllowanceCalculation.BLL.Extensions;

public static class StudentExtension
{
	public static IEnumerable<int?> GetGrades(this StudentModel student)
	{
		return student.StudentGrades.Select(p => p.Grade).ToList();
	}

	public static bool IsExcellent(this StudentModel student, IEnumerable<int?> excellentGrades)
	{
		return !student.GetGrades().Except(excellentGrades).Any();
	}

	public static double GetGradePointAverage(this StudentModel student)
	{
		return (double)student.GetGrades().Average()!;
	}
}