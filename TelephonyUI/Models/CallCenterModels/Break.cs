using TelephonyUI.Models.CallCenterEnums;

namespace TelephonyUI.Models.CallCenterModels
{
	public class Break
	{
		public int Id { get; set; }
		public string AgentId { get; set; }
		public Agent Agent { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime? EndTime { get; set; }
		public BreakType Type { get; set; } // Lunch/Personal/Technical
	}
}
