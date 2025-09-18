using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiUpdateCheckRuleRequest
	{
		[DataMember(Name = "action")]
		[Preserve]
		public ApiUpdateCheckAction Action { get; set; }

		[DataMember(Name = "platform")]
		[Preserve]
		public ApiUpdateCheckPlatform Platform { get; set; }

		[DataMember(Name = "version_end")]
		[Preserve]
		public string VersionEnd { get; set; }

		[DataMember(Name = "version_start")]
		[Preserve]
		public string VersionStart { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
