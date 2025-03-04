using System.Threading.Tasks;
using TelephonyUI.Models.CallCenterEnums;

namespace TelephonyUI.Models.CallCenterModels
{
	public class Case
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }
		public string Subject { get; set; }
		public string Description { get; set; }
		public CaseStatus Status { get; set; }
		public CasePriority Priority { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime? ResolvedDate { get; set; }
		public string AssignedAgentId { get; set; }
		public Agent AssignedAgent { get; set; }
	}
}
