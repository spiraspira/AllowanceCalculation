using AllowanceCalculation.DAL.Interfaces;

namespace AllowanceCalculation.DAL.Entities
{
	public class EntityWithId : IEntityWithId
	{
		public int Id { get; set; }
	}
}