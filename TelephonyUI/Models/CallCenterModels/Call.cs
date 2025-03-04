using Microsoft.VisualBasic;
using TelephonyUI.Models.CallCenterEnums;
using CallType = TelephonyUI.Models.CallCenterEnums.CallType;

namespace TelephonyUI.Models.CallCenterModels
{
	public class Call
	{
		public int Id { get; set; }
		public string CallSid { get; set; } // External telephony system ID
		public string CallerNumber { get; set; }
		public string DestinationNumber { get; set; }
		public DateTime StartTime { get; set; }
		public DateTime? EndTime { get; set; }
		public CallType CallType { get; set; } // Inbound/Outbound
		public CallStatus Status { get; set; }
		public int? QueueId { get; set; }
		public Queue Queue { get; set; }
		public string AgentId { get; set; }
		public Agent Agent { get; set; }
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }
		public int? DispositionId { get; set; }
		public Disposition Disposition { get; set; }
		public TimeSpan WaitTime { get; set; }
		public TimeSpan TalkTime { get; set; }
		public string Notes { get; set; }
		public bool IsRecorded { get; set; }
		public string RecordingUrl { get; set; }
		public string TransferredFromAgent { get; set; }
	}
}
