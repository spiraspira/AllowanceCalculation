namespace AllowanceCalculation.DAL.InitialData;

public class StudentInitial
{
	public static readonly Student[]
		Students =
		{
			new() { Id = 1, Name = "Заборонок Н.А.", IsOnBudget = true, IsSocialWorkActive = false, GroupId = 1 },
			new() { Id = 2, Name = "Адуцкевич Н.С.", IsOnBudget = false, IsSocialWorkActive = false, GroupId = 1 },
			new() { Id = 3, Name = "Панфилович Н.А.", IsOnBudget = true, IsSocialWorkActive = true, GroupId = 1 },
			new() { Id = 4, Name = "Чебупеля Н.А.", IsOnBudget = true, IsSocialWorkActive = false, GroupId = 2 },
			new() { Id = 5, Name = "Неизвестен Н.А.", IsOnBudget = true, IsSocialWorkActive = false, GroupId = 2 },
			new() { Id = 6, Name = "Максаков Н.А.", IsOnBudget = true, IsSocialWorkActive = false, GroupId = 3 },
			new() { Id = 7, Name = "Бротелло Н.А.", IsOnBudget = true, IsSocialWorkActive = false, GroupId = 3 },
		};
}