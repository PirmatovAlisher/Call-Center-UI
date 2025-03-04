using TelephonyUI.Models.CallCenterEnums;

namespace TelephonyUI.Models.CallCenterModels
{
	public class Customer
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string AccountNumber { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime LastContactDate { get; set; }
		public CustomerType Type { get; set; } // New/Existing/VIP
		public List<InteractionHistory> Interactions { get; set; }
		public List<Case> Cases { get; set; }
		//public List<CustomerTag> Tags { get; set; }
	}
}
