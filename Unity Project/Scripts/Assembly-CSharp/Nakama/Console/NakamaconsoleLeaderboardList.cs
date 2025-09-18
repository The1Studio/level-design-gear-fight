using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class NakamaconsoleLeaderboardList
	{
		[DataMember(Name = "leaderboards")]
		[Preserve]
		public List<NakamaconsoleLeaderboard> Leaderboards { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
