using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocAchievementsData
	{
		[DataMember(Name = "sections")]
		[Preserve]
		public List<ApiMocAchievementSection> Sections { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
