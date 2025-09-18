using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMobWarsData
	{
		[Preserve]
		[DataMember(Name = "event_id")]
		public string EventId { get; set; }

		[DataMember(Name = "event_status")]
		[Preserve]
		public MobWarsDataMobWarsStatus EventStatus { get; set; }

		[Preserve]
		[DataMember(Name = "player_data")]
		public ApiMobWarsPlayerData PlayerData { get; set; }

		[DataMember(Name = "point_config")]
		[Preserve]
		public ApiMobWarsPointConfig PointConfig { get; set; }

		[DataMember(Name = "seconds_until_end")]
		[Preserve]
		public int SecondsUntilEnd { get; set; }

		[Preserve]
		[DataMember(Name = "seconds_until_start")]
		public int SecondsUntilStart { get; set; }

		[Preserve]
		[DataMember(Name = "team_blue")]
		public ApiMobWarsTeamData TeamBlue { get; set; }

		[DataMember(Name = "team_red")]
		[Preserve]
		public ApiMobWarsTeamData TeamRed { get; set; }

		[DataMember(Name = "week_num_since_epoch")]
		[Preserve]
		public int WeekNumSinceEpoch { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
