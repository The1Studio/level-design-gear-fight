using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocAchievementSection
	{
		[DataMember(Name = "achievements")]
		[Preserve]
		public List<ApiMocAchievement> Achievements { get; set; }

		[DataMember(Name = "section_type")]
		[Preserve]
		public int SectionType { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
