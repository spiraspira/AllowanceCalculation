namespace AllowanceCalculation.BLL.Interfaces;

public interface IAllowanceCalculationService
{
	double GetAllowance(int id, double allowanceBase);
}