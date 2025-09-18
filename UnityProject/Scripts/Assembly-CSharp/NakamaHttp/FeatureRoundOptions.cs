using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class FeatureRoundOptions
	{
		[DataMember(Name = "feature_id")]
		[Preserve]
		public string FeatureId;

		[DataMember(Name = "start_in_seconds_from_now")]
		[Preserve]
		public int StartInSecondsFromNow;

		[DataMember(Name = "duration_in_seconds")]
		[Preserve]
		public int DurationInSeconds;

		[Preserve]
		[DataMember(Name = "data")]
		public string Data;

		public FeatureRoundOptions()
		{
		}

		public FeatureRoundOptions(string featureIdParam, int startInSecondsFromNowParam, int durationInSecondsParam, string dataParam)
		{
		}
	}
}
