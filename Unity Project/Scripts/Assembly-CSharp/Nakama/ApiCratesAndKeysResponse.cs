using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiCratesAndKeysResponse
	{
		[DataMember(Name = "crates_and_keys_data")]
		[Preserve]
		public ApiCratesAndKeysData CratesAndKeysData { get; set; }

		[Preserve]
		[DataMember(Name = "crates_and_keys_data_next")]
		public ApiCratesAndKeysData CratesAndKeysDataNext { get; set; }

		[DataMember(Name = "feature_data")]
		[Preserve]
		public ApiFeatureData FeatureData { get; set; }

		[DataMember(Name = "feature_data_next")]
		[Preserve]
		public ApiFeatureData FeatureDataNext { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
