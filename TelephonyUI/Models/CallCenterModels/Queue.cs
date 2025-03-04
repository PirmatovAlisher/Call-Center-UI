namespace TelephonyUI.Models.CallCenterModels
{
	public class Queue
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public int Priority { get; set; }
		public TimeSpan MaxWaitTime { get; set; }
		public int ServiceLevelThreshold { get; set; } // Seconds
		public List<Agent> Agents { get; set; }
		public List<Call> Calls { get; set; }
		public DateTime? LastReset { get; set; }
	}
}
