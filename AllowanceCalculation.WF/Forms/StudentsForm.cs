namespace AllowanceCalculation.WF.Forms;

public partial class StudentsForm : Form
{
	private readonly IServiceProvider? _serviceProvider;

	private IEnumerable<StudentModel> _students;

	private readonly List<int> _listBoxStudentIds = new();

	public StudentsForm(IServiceProvider? serviceProvider)
	{
		InitializeComponent();

		_serviceProvider = serviceProvider;
	}

	private void StudentsForm_Load(object sender, EventArgs e)
	{
		RefreshDataAndListBox();
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
}