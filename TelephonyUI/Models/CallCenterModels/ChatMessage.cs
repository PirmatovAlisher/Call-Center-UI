namespace TelephonyUI.Models.CallCenterModels
{
	public class ChatMessage
	{
		public int Id { get; set; }
		public int InteractionHistoryId { get; set; }
		public InteractionHistory Interaction { get; set; }
		public string Content { get; set; }
		public DateTime Timestamp { get; set; }
		public bool IsCustomerMessage { get; set; }
	}
}
