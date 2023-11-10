using System.Runtime.CompilerServices;

namespace AllowanceCalculation.WF.Forms;

public partial class CreateUpdateStudentForm : Form
{
	private readonly IServiceProvider? _serviceProvider;

	private readonly bool _isCreate;

	private readonly int _studentId;

	private StudentModel _student;

	public CreateUpdateStudentForm(IServiceProvider serviceProvider, bool isCreate, int studentId = 0)
	{
		InitializeComponent();

		_serviceProvider = serviceProvider;

		_isCreate = isCreate;

		_studentId = studentId;
	}

	private async void button_Add_Click(object sender, EventArgs e)
	{
		if (textBox_Name.Text.Length is <= 0 or > 30)
		{
			MessageBox.Show(
				"Введите имя (до 30 символов).",
				"Ошибка",
				MessageBoxButtons.OK,
				MessageBoxIcon.Hand);

			return;
		}

		bool isNewGroup = false;

		if (_isCreate)
		{
			_student.GroupId = (int)comboBox_Group.SelectedValue;
		}
		else if (_student.GroupId != (int)comboBox_Group.SelectedValue)
		{
			_student.GroupId = (int)comboBox_Group.SelectedValue;

			foreach (var grade in _student.StudentGrades)
			{
				await _serviceProvider.DeleteRecordAsync<StudentGradeModel>(grade.Id);
			}

			isNewGroup = true;
		}
		

		_student.Name = textBox_Name.Text;

		_student.IsSocialWorkActive = checkBox_SocialWork.Checked;

		_student.IsOnBudget = checkBox_OnBudget.Checked;

		if (_isCreate)
		{
			_student = await _serviceProvider.AddRecordAsync(_student);
		}
		else
		{
			await _serviceProvider.UpdateRecordAsync(_student);
		}

		if (_isCreate || isNewGroup)
		{
			var groupSubjects = await _serviceProvider.GetTableAsync<GroupSubjectModel>();

			groupSubjects = groupSubjects.Where(g => g.GroupId == _student.GroupId).ToList();

			foreach (var groupSubject in groupSubjects)
			{
				await _serviceProvider.AddRecordAsync(new StudentGradeModel
				{
					StudentId = _student.Id,
					SubjectId = groupSubject.SubjectId,
					Grade = 0
				});
			}
		}

		((AdminForm)Owner).RefreshDataAndListBox();

		Close();
	}

	private async void AddStudentForm_Load(object sender, EventArgs e)
	{
		var _groups = await _serviceProvider.GetTableAsync<GroupModel>();

		comboBox_Group.Populate(_groups, "Name", "Id");

		if (_isCreate)
		{
			button_Add.Text = "Добавить";

			_student = new StudentModel();
		}
		else
		{
			button_Add.Text = "Сохранить";

			_student = await _serviceProvider.GetRecordAsync<StudentModel>(_studentId);

			comboBox_Group.SelectedValue = _student.GroupId;

			textBox_Name.Text = _student.Name;

			checkBox_OnBudget.Checked = (bool)_student.IsOnBudget;

			checkBox_SocialWork.Checked = (bool)_student.IsSocialWorkActive;
		}
	}
}