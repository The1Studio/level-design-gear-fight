using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleEditLiveOpRoundRequest
	{
		[DataMember(Name = "end_epoch_seconds")]
		[Preserve]
		public long EndEpochSeconds { get; set; }

		[DataMember(Name = "feature_id")]
		[Preserve]
		public string FeatureId { get; set; }

		[Preserve]
		[DataMember(Name = "round_data")]
		public string RoundData { get; set; }

		[Preserve]
		[DataMember(Name = "round_id")]
		public string RoundId { get; set; }

		[DataMember(Name = "start_epoch_seconds")]
		[Preserve]
		public long StartEpochSeconds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
