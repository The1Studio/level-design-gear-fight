using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiSeasonPassResponse
	{
		[Preserve]
		[DataMember(Name = "feature_data")]
		public ApiFeatureData FeatureData { get; set; }

		[Preserve]
		[DataMember(Name = "feature_data_next")]
		public ApiFeatureData FeatureDataNext { get; set; }

		[Preserve]
		[DataMember(Name = "season_pass_data")]
		public ApiSeasonPassData SeasonPassData { get; set; }

		[Preserve]
		[DataMember(Name = "season_pass_data_next")]
		public ApiSeasonPassData SeasonPassDataNext { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
