using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class GetVoodooTuneConfigResp
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId;

		[Preserve]
		[DataMember(Name = "config_json")]
		public string ConfigJson;

		public GetVoodooTuneConfigResp()
		{
		}

		public GetVoodooTuneConfigResp(string configIdParam, string configJsonParam)
		{
		}
	}
}
