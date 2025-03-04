using TelephonyUI.Models.CallCenterEnums;

namespace TelephonyUI.Models.CallCenterModels
{
	public class Shift
	{
		public int Id { get; set; }
		public string AgentId { get; set; }
		public Agent Agent { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime EndTime { get; set; }
		public ShiftType Type { get; set; } // Regular/Overtime
		public bool IsActive { get; set; }
	}
}
