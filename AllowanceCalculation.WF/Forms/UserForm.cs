namespace AllowanceCalculation.WF.Forms;

public partial class UserForm : Form
{
	private IServiceProvider? _serviceProvider;

	private int? _userId;

	public UserForm(IServiceProvider serviceProvider, int? userId)
	{
		InitializeComponent();

		_serviceProvider = serviceProvider;

		_userId = userId;
	}
}