namespace AllowanceCalculation.WF.Forms;

public partial class GroupsForm : Form
{
	private readonly IServiceProvider? _serviceProvider;

	private List<GroupModel> _groups;

	public GroupsForm(IServiceProvider? serviceProvider)
	{
		InitializeComponent();

		_serviceProvider = serviceProvider;
	}

	private async Task LoadData()
	{
		_groups = (await _serviceProvider.GetTableAsync<GroupModel>()).OrderBy(g => g.Name).ToList();

		listBox_Groups.DataSource = _groups;

		listBox_Groups.DisplayMember = "Name";

		listBox_Groups.ValueMember = "Id";
	}

	private async void GroupsForm_Load(object sender, EventArgs e)
	{
		await LoadData();
	}

	private async void button_Delete_Click(object sender, EventArgs e)
	{
		if (listBox_Groups.SelectedIndex == -1)
		{
			return;
		}

		DialogResult dialogResult =
			MessageBox.Show("Удалить?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

		if (dialogResult == DialogResult.Yes)
		{
			await _serviceProvider.DeleteRecordAsync<GroupModel>((int)listBox_Groups.SelectedValue);
		}

		await LoadData();
	}

	private async void button_Add_Click(object sender, EventArgs e)
	{
		if (textBox_GroupName.Text.Length is <= 0 or > 10)
		{
			return;
		}

		GroupModel newGroup = new GroupModel();

		newGroup.Name = textBox_GroupName.Text;

		await _serviceProvider.AddRecordAsync(newGroup);

		LoadData();
	}

	private void GroupsForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		(Owner as AdminForm).RefreshDataAndListBox();
	}

	private async void button_Update_Click(object sender, EventArgs e)
	{
		if (textBox_GroupName.Text.Length is <= 0 or > 10 || listBox_Groups.SelectedIndex == -1)
		{
			return;
		}

		var group = listBox_Groups.SelectedItem as GroupModel;

		group.Name = textBox_GroupName.Text;

		await _serviceProvider.UpdateRecordAsync(group);

		LoadData();
	}
}