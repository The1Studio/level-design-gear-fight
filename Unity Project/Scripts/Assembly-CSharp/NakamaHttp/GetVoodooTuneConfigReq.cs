using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class GetVoodooTuneConfigReq
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId;

		[Preserve]
		[DataMember(Name = "feature_id")]
		public string FeatureId;

		public GetVoodooTuneConfigReq()
		{
		}

		public GetVoodooTuneConfigReq(string configIdParam, string featureIdParam)
		{
		}
	}
}
