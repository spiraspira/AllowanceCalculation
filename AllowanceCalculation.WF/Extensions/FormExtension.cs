namespace AllowanceCalculation.WF.Extensions;

public static class FormExtension
{
	public static void SpawnForm(this Form form, Form childForm, bool showDialog = false)
	{
		childForm.SetDefaultSettings();

		childForm.Owner = form;

		childForm.FormClosing += ChildFormClosing!;

		if (showDialog)
		{
			childForm.ShowDialog();
		}
		else
		{
			childForm.Show();

			form.Hide();
		}
	}

	public static void SetDefaultSettings(this Form form)
	{
		form.MaximizeBox = false;

		form.MinimizeBox = false;

		form.FormBorderStyle = FormBorderStyle.FixedSingle;

		form.StartPosition = FormStartPosition.CenterScreen;

		form.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

		form.BackColor = Color.AntiqueWhite;
	}

	private static void ChildFormClosing(object sender, CancelEventArgs e)
	{
		if ((sender as Form)?.Owner is not null)
		{
			(sender as Form)?.Owner!.Show();
			(sender as Form)?.Owner!.Refresh();
		}
	}
}