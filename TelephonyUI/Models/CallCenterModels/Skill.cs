namespace TelephonyUI.Models.CallCenterModels
{
	public class Skill
	{
		public int Id { get; set; }
		public string Name { get; set; } // e.g., "Billing", "Technical Support"
		public string Description { get; set; }
		public List<AgentSkill> AgentSkills { get; set; }
	}
}
