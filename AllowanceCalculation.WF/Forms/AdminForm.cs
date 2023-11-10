namespace AllowanceCalculation.WF.Forms;

public partial class AdminForm : Form
{
	private IServiceProvider? _serviceProvider;

	public AdminForm(IServiceProvider serviceProvider)
	{
		InitializeComponent();

		_serviceProvider = serviceProvider;
	}

	private void button_Students_Click(object sender, EventArgs e)
	{
		StudentsForm studentsForm = new StudentsForm(_serviceProvider);

		this.SpawnForm(studentsForm);
	}

	private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		(Owner as AuthorizationForm).AuthorizationForm_Load(sender, e);
	}
}