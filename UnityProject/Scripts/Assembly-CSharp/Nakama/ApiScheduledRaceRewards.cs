using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiScheduledRaceRewards
	{
		[DataMember(Name = "number_of_streak_winners")]
		[Preserve]
		public int NumberOfStreakWinners { get; set; }

		[Preserve]
		[DataMember(Name = "position_to_reward")]
		public Dictionary<string, ApiRewardItems> PositionToReward { get; set; }

		[Preserve]
		[DataMember(Name = "streak_reward")]
		public ApiRewardItems StreakReward { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
