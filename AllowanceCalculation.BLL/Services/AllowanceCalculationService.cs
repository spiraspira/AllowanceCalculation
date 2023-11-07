namespace AllowanceCalculation.BLL.Services;

public class AllowanceCalculationService : IAllowanceCalculationService
{
	readonly ICommonService<StudentModel> _studentRepo;

	readonly int?[] _excellentGrades = { 9, 10 };

	private const double
		ExcellenceIncrease = 1.25,
		SocialWorkActiveIncrease = 1.5,
		GradePointAverageRequired = 5.0;

	public AllowanceCalculationService(ICommonService<StudentModel> studentRepo)
	{
		_studentRepo = studentRepo;
	}

	public double GetAllowance(int id, double allowanceBase)
	{
		var
			student = GetStudent(id);

		var
			grades = student.GetGrades();

		bool
			isSocialWorkActive = student.IsSocialWorkActive ?? false,
			isOnBudget = student.IsOnBudget ?? false,
			isExcellent = student.IsExcellent(_excellentGrades),
			isIncentivized = student.GetGradePointAverage() > GradePointAverageRequired;

		if (!isOnBudget || !isIncentivized)
		{
			return 0;
		}

		if (isExcellent && isSocialWorkActive)
		{
			return allowanceBase * SocialWorkActiveIncrease;
		}

		if (isExcellent)
		{
			return allowanceBase * ExcellenceIncrease;
		}

		return allowanceBase;
	}

	private StudentModel GetStudent(int id)
	{
		return _studentRepo.Get(id).Result;
	}
}