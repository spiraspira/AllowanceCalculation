using System.Configuration;
using System.Linq.Expressions;

namespace AllowanceCalculation.WF.Forms;

public partial class AdminForm : Form
{
	private readonly IServiceProvider? _serviceProvider;

	private IEnumerable<StudentModel> _students;

	private readonly List<int> _listBoxStudentIds = new();

	private readonly IConfiguration? _configuration;

	public AdminForm(IServiceProvider? serviceProvider, IConfiguration? configuration)
	{
		InitializeComponent();

		_serviceProvider = serviceProvider;

		_configuration = configuration;
	}

	private void StudentsForm_Load(object sender, EventArgs e)
	{
		RefreshDataAndListBox();

		textBox_AllowanceBase.Text = _configuration.GetValue<string>("AllowanceBase");
	}

	public async void RefreshDataAndListBox()
	{
		_students = await _serviceProvider.GetTableAsync<StudentModel>();

		var _groups = await _serviceProvider.GetTableAsync<GroupModel>();

		comboBox_Groups.Populate(_groups, "Name", "Id");

		_students = _students.OrderBy(s => s.Group.Name).ThenBy(s => s.Name).ToList();

		FillListBoxWithStudents(listBox_Students, _students, _listBoxStudentIds);
	}

	private void FillListBoxWithStudents(ListBox listBox, IEnumerable<StudentModel> students, List<int> listBoxStudentIds)
	{
		listBox.Items.Clear();

		listBoxStudentIds.Clear();

		foreach (var student in students)
		{
			string line = $"{student.Group.Name,-10}" +
						  $"{student.Name,-20}" +
						  $"Общественная работа: {student.IsSocialWorkActive.ToCustomString(),-4}" +
						  $"Бюджет: {student.IsOnBudget.ToCustomString()}";

			listBoxStudentIds.Add(student.Id);

			listBox.Items.Add(line);
		}
	}

	private void button_Sort_Click(object sender, EventArgs e)
	{
		FillListBoxWithStudents(
			listBox_Students,
			_students.Where(s => s.Group.Id == (int)comboBox_Groups.SelectedValue).ToList(),
			_listBoxStudentIds);
	}

	private void button_Reset_Click(object sender, EventArgs e)
	{
		FillListBoxWithStudents(listBox_Students, _students, _listBoxStudentIds);
	}

	private void button_Add_Click(object sender, EventArgs e)
	{
		CreateUpdateStudentForm createUpdateStudentForm = new CreateUpdateStudentForm(_serviceProvider, true);

		this.SpawnForm(createUpdateStudentForm, true);
	}

	private async void button_Delete_Click(object sender, EventArgs e)
	{
		if (listBox_Students.SelectedIndex == -1)
		{
			return;
		}

		DialogResult dialogResult =
			MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		if (dialogResult == DialogResult.Yes)
		{
			await _serviceProvider.DeleteRecordAsync<StudentModel>(_listBoxStudentIds[listBox_Students.SelectedIndex]);
		}

		RefreshDataAndListBox();
	}

	private void button_Update_Click(object sender, EventArgs e)
	{
		if (listBox_Students.SelectedIndex == -1)
		{
			return;
		}

		var createUpdateStudentForm = new CreateUpdateStudentForm(
				_serviceProvider,
				false,
				_listBoxStudentIds[listBox_Students.SelectedIndex]);

		this.SpawnForm(createUpdateStudentForm, true);
	}

	private void button_StudentGrades_Click(object sender, EventArgs e)
	{
		if (listBox_Students.SelectedIndex == -1)
		{
			return;
		}

		StudentGradesForm studentGradesForm = new StudentGradesForm(
			_serviceProvider,
			_listBoxStudentIds[listBox_Students.SelectedIndex]);

		this.SpawnForm(studentGradesForm);
	}

	private void StudentsForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		(Owner as AuthorizationForm).AuthorizationForm_Load(sender, e);
	}

	private void button_AddGroup_Click(object sender, EventArgs e)
	{
		GroupsForm groupsForm = new GroupsForm(_serviceProvider);

		this.SpawnForm(groupsForm);
	}

	private void button_AllowanceBase_Click(object sender, EventArgs e)
	{
		if (textBox_AllowanceBase.Text.Length == 0)
		{
			return;
		}

		double allowanceBase;

		try
		{
			allowanceBase = double.Parse(textBox_AllowanceBase.Text.Replace('.', ','));
		}
		catch
		{
			return;
		}

		_configuration["AllowanceBase"] = allowanceBase.ToString();

		MessageBox.Show("Сохранено");
	}
}