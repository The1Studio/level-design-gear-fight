using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiSetVoodooTuneConfigResp
	{
		[DataMember(Name = "config_id")]
		[Preserve]
		public string ConfigId { get; set; }

		[DataMember(Name = "config_json")]
		[Preserve]
		public string ConfigJson { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
