namespace AllowanceCalculation.BLL.Interfaces;

public interface IAllowanceCalculationService
{
	Task<double> GetAllowance(int id, double allowanceBase);
}