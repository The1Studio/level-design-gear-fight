using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGetVoodooTuneConfigReq
	{
		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		[DataMember(Name = "feature_id")]
		[Preserve]
		public string FeatureId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
