using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class FeatureRound
	{
		[DataMember(Name = "feature_id")]
		[Preserve]
		public string FeatureId;

		[DataMember(Name = "round_id")]
		[Preserve]
		public string RoundId;

		[DataMember(Name = "start_epoch")]
		[Preserve]
		public int StartEpoch;

		[DataMember(Name = "end_epoch")]
		[Preserve]
		public int EndEpoch;

		[DataMember(Name = "round_data")]
		[Preserve]
		public string RoundData;

		public FeatureRound()
		{
		}

		public FeatureRound(string featureIdParam, string roundIdParam, int startEpochParam, int endEpochParam, string roundDataParam)
		{
		}
	}
}
