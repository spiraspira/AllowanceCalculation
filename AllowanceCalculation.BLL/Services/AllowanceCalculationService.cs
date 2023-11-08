namespace AllowanceCalculation.BLL.Services;

public class AllowanceCalculationService : GenericService<StudentModel, Student>, IAllowanceCalculationService
{
	private readonly int?[] _excellentGrades = { 9, 10 };

	private const double
		ExcellenceIncrease = 1.25,
		SocialWorkActiveIncrease = 1.5,
		GradePointAverageRequired = 5.0;

	public AllowanceCalculationService(IRepository<Student> repository, IMapper mapper) : base(repository, mapper)
	{

	}

	public double GetAllowance(int id, double allowanceBase)
	{
		var
			student = Get(id).Result;

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
}