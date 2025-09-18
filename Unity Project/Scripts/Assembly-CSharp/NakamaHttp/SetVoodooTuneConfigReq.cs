using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class SetVoodooTuneConfigReq
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId;

		[Preserve]
		[DataMember(Name = "config_json")]
		public string ConfigJson;

		public SetVoodooTuneConfigReq()
		{
		}

		public SetVoodooTuneConfigReq(string configIdParam, string configJsonParam)
		{
		}
	}
}
