using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleLiveOpTypeDefaultData
	{
		[Preserve]
		[DataMember(Name = "feature_data_default")]
		public string FeatureDataDefault { get; set; }

		[Preserve]
		[DataMember(Name = "feature_id")]
		public string FeatureId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
