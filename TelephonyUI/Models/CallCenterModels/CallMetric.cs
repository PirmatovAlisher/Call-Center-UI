namespace TelephonyUI.Models.CallCenterModels
{
	public class CallMetric
	{
		public int Id { get; set; }
		public DateTime MetricDate { get; set; }
		public int CallsHandled { get; set; }
		public int AbandonedCalls { get; set; }
		public double AverageWaitTime { get; set; }
		public double AverageTalkTime { get; set; }
		public double ServiceLevel { get; set; } // % answered in threshold
		public int QueueId { get; set; }
		public Queue Queue { get; set; }
	}
}
