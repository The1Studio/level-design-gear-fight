using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiFeatureData
	{
		[Preserve]
		[DataMember(Name = "feature_state")]
		public ApiFeatureState FeatureState { get; set; }

		[DataMember(Name = "round_data")]
		[Preserve]
		public ApiRoundData RoundData { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
