namespace TelephonyUI.Models.CallCenterModels
{
	public class IVRMenu
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		//public List<IVROption> Options { get; set; }
		public bool IsActive { get; set; }
	}
}
