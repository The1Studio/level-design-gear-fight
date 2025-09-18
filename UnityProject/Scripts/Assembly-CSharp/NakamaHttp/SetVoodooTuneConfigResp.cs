using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class SetVoodooTuneConfigResp
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId;

		[DataMember(Name = "config_json")]
		[Preserve]
		public string ConfigJson;

		public SetVoodooTuneConfigResp()
		{
		}

		public SetVoodooTuneConfigResp(string configIdParam, string configJsonParam)
		{
		}
	}
}
