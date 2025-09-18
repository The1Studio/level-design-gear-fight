using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class MocAchievementSection
	{
		[Preserve]
		[DataMember(Name = "achievements")]
		public List<MocAchievement> Achievements;

		[Preserve]
		[DataMember(Name = "section_type")]
		public int SectionType;

		public MocAchievementSection()
		{
		}

		public MocAchievementSection(List<MocAchievement> achievementsParam, int sectionTypeParam)
		{
		}
	}
}
