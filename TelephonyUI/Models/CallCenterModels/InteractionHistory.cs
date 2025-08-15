using TelephonyUI.Models.CallCenterEnums;
using static TelephonyUI.Pages.Home;

namespace TelephonyUI.Models.CallCenterModels
{
	public class InteractionHistory
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }
		public DateTime InteractionDate { get; set; }
		public InteractionType Type { get; set; } // Call/Email/Chat
		public string Summary { get; set; }
		public int? RelatedCallId { get; set; }
		public string AgentId { get; set; }
		public Agent Agent { get; set; }

		public ChatStatus Status { get; set; } = ChatStatus.Active;
		public List<ChatMessage> Messages { get; set; } = new List<ChatMessage>();
		public ChatMessage LastMessage => Messages.LastOrDefault();
	}
}
