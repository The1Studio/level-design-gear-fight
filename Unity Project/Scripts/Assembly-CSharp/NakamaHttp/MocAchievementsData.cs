using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class MocAchievementsData
	{
		[DataMember(Name = "sections")]
		[Preserve]
		public List<MocAchievementSection> Sections;

		public MocAchievementsData()
		{
		}

		public MocAchievementsData(List<MocAchievementSection> sectionsParam)
		{
		}
	}
}
