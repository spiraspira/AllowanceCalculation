namespace AllowanceCalculation.WF.Extensions;

public static class FormExtension
{
	public static void SpawnForm(this Form form, Form childForm)
	{
		childForm.Owner = form;

		childForm.FormClosing += ChildFormClosing!;

		childForm.Show();

		form.Hide();
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