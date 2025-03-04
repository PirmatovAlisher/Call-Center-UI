namespace TelephonyUI.Models.CallCenterModels
{
	public class CustomerFeedback
	{
		public int Id { get; set; }
		public int CustomerId { get; set; }
		public Customer Customer { get; set; }
		public int InteractionId { get; set; }
		public InteractionHistory Interaction { get; set; }
		public int Rating { get; set; } // 1-5
		public string Comments { get; set; }
		public DateTime FeedbackDate { get; set; }
		public bool FollowUpRequired { get; set; }
	}
}
