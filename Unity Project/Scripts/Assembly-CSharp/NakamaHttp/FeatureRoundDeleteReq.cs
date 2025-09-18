using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class FeatureRoundDeleteReq
	{
		[Preserve]
		[DataMember(Name = "feature_id")]
		public string FeatureId;

		[Preserve]
		[DataMember(Name = "round_id")]
		public string RoundId;

		public FeatureRoundDeleteReq()
		{
		}

		public FeatureRoundDeleteReq(string featureIdParam, string roundIdParam)
		{
		}
	}
}
