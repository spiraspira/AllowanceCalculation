using System.Windows.Forms;

namespace AllowanceCalculation.WF.Forms;

public partial class StudentGradesForm : Form
{
	private readonly IServiceProvider _serviceProvider;

	private readonly int _studentId;

	private List<StudentGradeModel> _gradesNumeric;

	private List<StudentGradeModel> _gradesPassFail;

	private StudentModel _student;

	public StudentGradesForm(IServiceProvider serviceProvider, int studentId)
	{
		InitializeComponent();

		_serviceProvider = serviceProvider;

		_studentId = studentId;
	}

	private async void StudentGradesForm_Load(object sender, EventArgs e)
	{
		await LoadData();

		SpawnPassFailGrades(_gradesPassFail);

		SpawnNumericGrades(_gradesNumeric);

		Text = $"{_student.Name}: оценки";
	}

	private void SpawnNumericGrades(List<StudentGradeModel> gradesNumeric)
	{
		for (int i = 0; i < gradesNumeric.Count; i++)
		{
			dataGridView_NumericGrades.Rows.Add();

			dataGridView_NumericGrades.Rows[i].Cells[0].Value = gradesNumeric[i].Id;

			dataGridView_NumericGrades.Rows[i].Cells[1].Value = gradesNumeric[i].Subject.Name;

			dataGridView_NumericGrades.Rows[i].Cells[2].Value = gradesNumeric[i].Grade;
		}
	}

	private async Task LoadData()
	{
		_student = await _serviceProvider.GetRecordAsync<StudentModel>(_studentId);

		var grades = await _serviceProvider.GetTableAsync<StudentGradeModel>();

		grades = grades.Where(g => g.StudentId == _studentId).ToList();

		_gradesNumeric = grades.Where(g => g.Subject.IsPassFailEvaluated is false).ToList();

		_gradesPassFail = grades.Where(g => g.Subject.IsPassFailEvaluated is true).ToList();
	}

	private void SpawnPassFailGrades(List<StudentGradeModel> gradesPassFail)
	{
		checkedListBox_PassFails.DisplayMember = "Text";

		foreach (var grade in gradesPassFail)
		{
			checkedListBox_PassFails.Items.Insert(0, new { Text = grade.Subject.Name, Id = grade.Id });

			if (grade.Grade != 0)
			{
				checkedListBox_PassFails.SetItemChecked(0, true);
			}
		}
	}

	private async void button_Save_Click(object sender, EventArgs e)
	{
		await SavePassFails();

		await SaveNumeric();

		Close();
	}

	private async Task SaveNumeric()
	{
		for (int i = 0; i < dataGridView_NumericGrades.Rows.Count; i++)
		{
			int grade;

			try
			{
				grade = (int)dataGridView_NumericGrades.Rows[i].Cells[2].Value;
			}
			catch
			{
				grade = int.Parse((string)dataGridView_NumericGrades.Rows[i].Cells[2].Value);
			}

			int id = (int)dataGridView_NumericGrades.Rows[i].Cells[0].Value;

			if (grade < 0)
			{
				grade = 0;

				dataGridView_NumericGrades.Rows[i].Cells[2].Value = 0;
			}

			if (grade > 10)
			{
				grade = 10;

				dataGridView_NumericGrades.Rows[i].Cells[2].Value = 10;
			}

			_gradesNumeric.FirstOrDefault(g => g.Id == id).Grade = grade;
		}

		foreach (var grade in _gradesNumeric)
		{
			await _serviceProvider.UpdateRecordAsync(grade);
		}
	}

	private async Task SavePassFails()
	{
		List<int> ids = new List<int>();

		foreach (var item in checkedListBox_PassFails.Items)
		{
			int id = (int)item.GetType().GetProperty("Id").GetValue(item);

			ids.Add(id);
		}

		for (int i = 0; i < checkedListBox_PassFails.Items.Count; i++)
		{
			int grade = checkedListBox_PassFails
				.GetItemCheckState(i) == CheckState.Checked ? 10 : 0;

			_gradesPassFail.FirstOrDefault(g => g.Id == ids[i]).Grade = grade;
		}

		foreach (var grade in _gradesPassFail)
		{
			await _serviceProvider.UpdateRecordAsync(grade);
		}
	}
}