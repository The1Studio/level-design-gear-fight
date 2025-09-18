using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGetVoodooTuneConfigResp
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[Preserve]
		[DataMember(Name = "config_json")]
		public string ConfigJson { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
