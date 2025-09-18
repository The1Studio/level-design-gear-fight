using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPiggyRaceBotProgressCSVRequest
	{
		[Preserve]
		[DataMember(Name = "bot_progress_snapshot_interval_seconds")]
		public int BotProgressSnapshotIntervalSeconds { get; set; }

		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "local_file_name")]
		[Preserve]
		public string LocalFileName { get; set; }

		[Preserve]
		[DataMember(Name = "total_race_duration_seconds")]
		public int TotalRaceDurationSeconds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
