using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPiggyRaceSyncRequest
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "current_race_bricks")]
		[Preserve]
		public int CurrentRaceBricks { get; set; }

		[DataMember(Name = "player_score")]
		[Preserve]
		public int PlayerScore { get; set; }

		[Preserve]
		[DataMember(Name = "race_id")]
		public int RaceId { get; set; }

		[Preserve]
		[DataMember(Name = "utc_offset")]
		public int UtcOffset { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
