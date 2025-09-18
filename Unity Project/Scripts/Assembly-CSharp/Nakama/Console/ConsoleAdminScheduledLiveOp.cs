using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleAdminScheduledLiveOp
	{
		[DataMember(Name = "end_epoch_seconds")]
		[Preserve]
		public long EndEpochSeconds { get; set; }

		[DataMember(Name = "round_data")]
		[Preserve]
		public string RoundData { get; set; }

		[Preserve]
		[DataMember(Name = "start_epoch_seconds")]
		public long StartEpochSeconds { get; set; }

		[Preserve]
		[DataMember(Name = "type")]
		public string Type { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
