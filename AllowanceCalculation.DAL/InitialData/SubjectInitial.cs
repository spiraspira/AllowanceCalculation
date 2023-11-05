namespace AllowanceCalculation.DAL.InitialData;

public class SubjectInitial
{
	public static readonly Subject[]
		Subjects =
		{
			new() {Id = 1, Name = "Английский язык", IsPassFailEvaluated = false},
			new() {Id = 2, Name = "Теория алгоритмов", IsPassFailEvaluated = true},
			new() {Id = 3, Name = "Инженерная графика", IsPassFailEvaluated = true},
			new() {Id = 4, Name = "Философия", IsPassFailEvaluated = true}
		};
}