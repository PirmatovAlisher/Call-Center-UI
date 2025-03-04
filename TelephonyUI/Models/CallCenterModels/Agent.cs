using TelephonyUI.Models.CallCenterEnums;

namespace TelephonyUI.Models.CallCenterModels
{
	public class Agent
	{
		public string Id { get; set; } // Linked to User ID
		public string Extension { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public AgentStatus Status { get; set; }
		public DateTime? StatusChangedAt { get; set; }
		public int? CurrentCallId { get; set; }
		public int QueueId { get; set; }
		public Queue Queue { get; set; }
		public List<AgentSkill> Skills { get; set; }
		public List<Shift> Shifts { get; set; }
		public DateTime DateCreated { get; set; }
		public bool IsActive { get; set; }
	}
}
