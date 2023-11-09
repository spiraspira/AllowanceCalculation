namespace AllowanceCalculation.WF.Forms;

public partial class UserForm : Form
{
	private readonly IServiceProvider? _serviceProvider;

	private readonly IConfiguration? _configuration;

	private readonly int? _userId;

	private StudentModel? _user;

	private IEnumerable<StudentGradeModel> _grades;

	private double _allowance;

	private readonly double _allowanceBase;

	public UserForm(IServiceProvider serviceProvider, IConfiguration configuration, int? userId)
	{
		InitializeComponent();

		_serviceProvider = serviceProvider;

		_userId = userId;

		_configuration = configuration;

		_allowanceBase = _configuration.GetValue<double>("AllowanceBase");
	}

	private async void UserForm_Load(object sender, EventArgs e)
	{
		_user = await _serviceProvider.GetRecordAsync<StudentModel>((int)_userId);

		_grades = await _serviceProvider.GetTableAsync<StudentGradeModel>();

		_grades = _grades.Where(g => g.StudentId == _userId).ToList();

		_allowance = await _serviceProvider.GetAllowance((int)_userId, _allowanceBase);

		SetData();
	}

	private void SetData()
	{
		label_UserName.Text = $"ФИО: {_user.Name}";

		label_UserGroup.Text = $"Группа: {_user.Group.Name}";

		label_UserSocialWork.Text = $"Участие в общественной работе: {_user.IsSocialWorkActive.ToCustomString()}";

		label_UserStatus.Text = $"На бюджете: {_user.IsOnBudget.ToCustomString()}";

		label_Allowance.Text = $"Ваша стипендия: {_allowance:C}";

		label_GradePointAverage.Text = $"Средний балл: {_user.GetGradePointAverage()}";

		label_IsExcellent.Text = $"Отличник: {_user.IsExcellent(new int?[] { 9, 10 }).ToCustomString()}";

		listBox_Grades.Items.Add($"{"[Предмет]",-30}[Оценка]");

		foreach (var grade in _grades)
		{
			bool isPassFail = (bool)grade.Subject.IsPassFailEvaluated;

			string passOrFail = string.Empty;

			if (isPassFail)
			{
				passOrFail = grade.Grade == 0 ? "Не зачет" : "Зачет";
			}

			string listLine = $"{grade.Subject.Name,-30}{(isPassFail ? passOrFail : grade.Grade)}";

			listBox_Grades.Items.Add(listLine);
		}
	}
}