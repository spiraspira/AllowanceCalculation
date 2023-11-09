namespace AllowanceCalculation.WF.Forms;

public partial class AdminForm : Form
{
	private IServiceProvider? _serviceProvider;

	public AdminForm(IServiceProvider serviceProvider)
	{
		InitializeComponent();

		_serviceProvider = serviceProvider;
	}
}