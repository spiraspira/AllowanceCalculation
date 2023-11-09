namespace AllowanceCalculation.WF.Extensions;

public static class BoolExtension
{
	public static string ToCustomString(this bool? boolean, string trueString = "Да", string falseString = "Нет")
	{
		return ToCustomString((bool)boolean, trueString, falseString);
	}

	public static string ToCustomString(this bool boolean, string trueString = "Да", string falseString = "Нет")
	{
		return boolean ? trueString : falseString;
	}
}