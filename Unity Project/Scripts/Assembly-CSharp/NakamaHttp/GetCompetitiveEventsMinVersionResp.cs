using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class GetCompetitiveEventsMinVersionResp
	{
		[DataMember(Name = "min_version_feature_enabled")]
		[Preserve]
		public string MinVersionFeatureEnabled;

		[DataMember(Name = "min_version_to_join")]
		[Preserve]
		public string MinVersionToJoin;

		public GetCompetitiveEventsMinVersionResp()
		{
		}

		public GetCompetitiveEventsMinVersionResp(string minVersionFeatureEnabledParam, string minVersionToJoinParam)
		{
		}
	}
}
