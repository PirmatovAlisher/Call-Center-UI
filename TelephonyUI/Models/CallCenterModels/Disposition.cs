namespace TelephonyUI.Models.CallCenterModels
{
	public class Disposition
	{
		public int Id { get; set; }
		public string Code { get; set; } // e.g., SALE, COMPLAINT
		public string Description { get; set; }
		public bool IsPositiveOutcome { get; set; }
		public bool RequiresNotes { get; set; }
		public TimeSpan WrapUpTime { get; set; }
	}
}
