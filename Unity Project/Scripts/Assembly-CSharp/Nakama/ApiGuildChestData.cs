using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChestData
	{
		[DataMember(Name = "event_id")]
		[Preserve]
		public int EventId { get; set; }

		[DataMember(Name = "ordered_players")]
		[Preserve]
		public List<ApiPlayerData> OrderedPlayers { get; set; }

		[Preserve]
		[DataMember(Name = "ordered_targets")]
		public List<ApiGuildChestTarget> OrderedTargets { get; set; }

		[Preserve]
		[DataMember(Name = "player_progress")]
		public ApiGuildChestPlayerProgress PlayerProgress { get; set; }

		[DataMember(Name = "points_per_action")]
		[Preserve]
		public Dictionary<string, int> PointsPerAction { get; set; }

		[DataMember(Name = "seconds_until_end")]
		[Preserve]
		public int SecondsUntilEnd { get; set; }

		[DataMember(Name = "status")]
		[Preserve]
		public GuildChestDataGuildChestStatus Status { get; set; }

		[DataMember(Name = "total_points")]
		[Preserve]
		public int TotalPoints { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
