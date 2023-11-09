namespace AllowanceCalculation.WF.Forms;

public partial class AuthorizationForm : Form
{
	private readonly IServiceProvider? _serviceProvider;

	private readonly IConfiguration? _configuration;

	private List<GroupModel>? _groups;

	private readonly string? _adminPassword;

	public AuthorizationForm(IServiceProvider serviceProvider, IConfiguration configuration)
	{
		InitializeComponent();

		_serviceProvider = serviceProvider;

		_configuration = configuration;

		_adminPassword = configuration.GetValue<string>("AdminPassword");

		//Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
	}

	public async Task<IEnumerable<T>> GetTableAsync<T>(IServiceProvider serviceProvider)
	{
		var groupRepository = (IGenericService<GroupModel>)serviceProvider
			.GetRequiredService(typeof(IGenericService<GroupModel>));

		return (IEnumerable<T>)await groupRepository.GetAll();
	}

	private async void AuthorizationForm_Load(object sender, EventArgs e)
	{
		_groups = (List<GroupModel>?)await GetTableAsync<GroupModel>(_serviceProvider);

		comboBox_UserGroup.Populate(_groups, nameof(GroupModel.Name), nameof(GroupModel.Id));

		comboBox_UserGroup_SelectedIndexChanged(sender, e);
	}

	private void comboBox_UserGroup_SelectedIndexChanged(object sender, EventArgs e)
	{
		var students = _groups
			.FirstOrDefault(g => g.Id == comboBox_UserGroup.SelectedValue as int?)
			?.Students; ;

		comboBox_UserName.Populate(students, nameof(StudentModel.Name), nameof(StudentModel.Id));
	}

	private void button_UserLogin_Click(object sender, EventArgs e)
	{
		UserForm userForm = new UserForm(_serviceProvider, comboBox_UserName.SelectedValue as int?);

		this.SpawnForm(userForm);
	}

	private void button_AdminLogin_Click(object sender, EventArgs e)
	{
		string password = maskedTextBox_AdminPassword.Text;

		if (password == _adminPassword)
		{
			AdminForm adminForm = new AdminForm(_serviceProvider);

			this.SpawnForm(adminForm);
		}
		else
		{
			MessageBox.Show(
				"Неправильный пароль",
				"Сообщение",
				MessageBoxButtons.OK,
				MessageBoxIcon.Hand);
		}
	}
}