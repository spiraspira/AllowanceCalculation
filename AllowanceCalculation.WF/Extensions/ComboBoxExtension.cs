namespace AllowanceCalculation.WF.Extensions;

public static class ComboBoxExtension
{
	public static void Populate(this ComboBox comboBox, IEnumerable<object> dataSource, string displayMember, string? valueMember)
	{
		comboBox.DataSource = dataSource;

		comboBox.DisplayMember = displayMember;

		comboBox.ValueMember = valueMember!;
	}
}