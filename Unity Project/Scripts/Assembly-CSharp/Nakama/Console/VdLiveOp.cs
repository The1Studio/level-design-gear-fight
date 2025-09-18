using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class VdLiveOp
	{
		[DataMember(Name = "end_date_seconds")]
		[Preserve]
		public long EndDateSeconds { get; set; }

		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		[DataMember(Name = "is_feature_enabled_for_current_user")]
		[Preserve]
		public bool IsFeatureEnabledForCurrentUser { get; set; }

		[DataMember(Name = "round_data")]
		[Preserve]
		public string RoundData { get; set; }

		[DataMember(Name = "start_date_seconds")]
		[Preserve]
		public long StartDateSeconds { get; set; }

		[DataMember(Name = "type")]
		[Preserve]
		public string Type { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
