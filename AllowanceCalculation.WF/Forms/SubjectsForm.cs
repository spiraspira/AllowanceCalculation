namespace AllowanceCalculation.WF.Forms;

public partial class SubjectsForm : Form
{
	private readonly IServiceProvider? _serviceProvider;

	private readonly int _groupId;

	private List<SubjectModel> _subjects;

	private List<GroupSubjectModel> _groupSubjects;

	public SubjectsForm(IServiceProvider? serviceProvider, int groupId)
	{
		InitializeComponent();

		_serviceProvider = serviceProvider;

		_groupId = groupId;
	}

	private async Task LoadData()
	{
		checkedListBox_Subjects.Items.Clear();

		checkedListBox_Subjects.DisplayMember = "Text";

		_subjects = (await _serviceProvider.GetTableAsync<SubjectModel>()).ToList();

		_groupSubjects = (await _serviceProvider.GetTableAsync<GroupSubjectModel>())
			.Where(g => g.GroupId == _groupId)
			.ToList();

		foreach (var subject in _subjects)
		{
			checkedListBox_Subjects.Items.Insert(0, new
			{
				Text = $"{subject.Name,-20}{(subject.IsPassFailEvaluated ?? false ? "Зачет" : "Оценка")}",
				Id = subject.Id
			});

			if (_groupSubjects.Select(g => g.SubjectId).Contains(subject.Id))
			{
				checkedListBox_Subjects.SetItemChecked(0, true);
			}
		}
	}

	private async void SubjectsForm_Load(object sender, EventArgs e)
	{
		await LoadData();
	}

	private async void button_Add_Click(object sender, EventArgs e)
	{
		if (textBox_SubjectName.Text.Length is <= 0 or > 30)
		{
			return;
		}

		SubjectModel newSubject = new SubjectModel();

		newSubject.Name = textBox_SubjectName.Text;

		newSubject.IsPassFailEvaluated = checkBox_PassFail.Checked;

		await _serviceProvider.AddRecordAsync(newSubject);

		LoadData();
	}

	private async void button_Update_Click(object sender, EventArgs e)
	{
		if (textBox_SubjectName.Text.Length is <= 0 or > 30 || checkedListBox_Subjects.SelectedIndex == -1)
		{
			return;
		}

		int id = (int)checkedListBox_Subjects.SelectedItem.GetType().GetProperty("Id").GetValue(checkedListBox_Subjects.SelectedItem);

		var subject = await _serviceProvider.GetRecordAsync<SubjectModel>(id);

		subject.Name = textBox_SubjectName.Text;

		subject.IsPassFailEvaluated = checkBox_PassFail.Checked;

		await _serviceProvider.UpdateRecordAsync(subject);

		LoadData();
	}

	private async void button_Delete_Click(object sender, EventArgs e)
	{
		if (checkedListBox_Subjects.SelectedIndex == -1)
		{
			return;
		}

		int id = (int)checkedListBox_Subjects.SelectedItem
			.GetType().GetProperty("Id")
			.GetValue(checkedListBox_Subjects.SelectedItem);

		DialogResult dialogResult =
			MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		if (dialogResult == DialogResult.Yes)
		{
			await _serviceProvider.DeleteRecordAsync<SubjectModel>(id);
		}

		LoadData();
	}

	private async void button_Save_Click(object sender, EventArgs e)
	{
		foreach (var groupSubject in _groupSubjects)
		{
			await _serviceProvider.DeleteRecordAsync<GroupSubjectModel>(groupSubject.Id);
		}

		foreach (var item in checkedListBox_Subjects.CheckedItems)
		{
			int subjectId = (int)item.GetType().GetProperty("Id").GetValue(item);

			GroupSubjectModel newGroupSubject = new GroupSubjectModel();

			newGroupSubject.SubjectId = subjectId;

			newGroupSubject.GroupId = _groupId;

			await _serviceProvider.AddRecordAsync(newGroupSubject);
		}

		var groupSubjectsIds = (await _serviceProvider.GetTableAsync<GroupSubjectModel>())
			.Where(g => g.GroupId == _groupId)
			.Select(g => g.SubjectId)
			.ToList();

		var students = (await _serviceProvider.GetTableAsync<StudentModel>())
			.Where(s => s.GroupId == _groupId)
			.ToList();

		foreach (var student in students)
		{
			var studentGradesSubjectsIds = (await _serviceProvider.GetTableAsync<StudentGradeModel>())
				.Where(g => g.StudentId == student.Id)
				.ToList();

			var subjectGradesToAdd = groupSubjectsIds
				.Where(x => !studentGradesSubjectsIds.Any(y => y.SubjectId == x))
				.ToList();

			var subjectGradesToDelete = studentGradesSubjectsIds
				.Where(x => !groupSubjectsIds.Any(y => y == x.SubjectId))
				.ToList();

			foreach (var subjectId in subjectGradesToAdd)
			{
				StudentGradeModel studentGrade = new StudentGradeModel();

				studentGrade.Grade = 0;

				studentGrade.SubjectId = subjectId;

				studentGrade.StudentId = student.Id;

				await _serviceProvider.AddRecordAsync(studentGrade);
			}

			foreach (var subject in subjectGradesToDelete)
			{
				await _serviceProvider.DeleteRecordAsync<StudentGradeModel>(subject.Id);
			}
		}
	}
}