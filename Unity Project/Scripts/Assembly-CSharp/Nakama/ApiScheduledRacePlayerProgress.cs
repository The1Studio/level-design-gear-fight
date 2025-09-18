using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduledRacePlayerProgress
	{
		[DataMember(Name = "max_win_streak")]
		[Preserve]
		public int MaxWinStreak { get; set; }

		[DataMember(Name = "places")]
		[Preserve]
		public List<int> Places { get; set; }

		[DataMember(Name = "points")]
		[Preserve]
		public int Points { get; set; }

		[Preserve]
		[DataMember(Name = "position_in_ranking")]
		public int PositionInRanking { get; set; }

		[DataMember(Name = "win_streak")]
		[Preserve]
		public int WinStreak { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
