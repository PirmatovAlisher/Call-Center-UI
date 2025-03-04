using TelephonyUI.Models.CallCenterEnums;

namespace TelephonyUI.Models.CallCenterModels
{
	public class AgentSkill
	{
		public int Id { get; set; }
		public string AgentId { get; set; }
		public Agent Agent { get; set; }
		public int SkillId { get; set; }
		public Skill Skill { get; set; }
		public ProficiencyLevel Level { get; set; }
	}
}
