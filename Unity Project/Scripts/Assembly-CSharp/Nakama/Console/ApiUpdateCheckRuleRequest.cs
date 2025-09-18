using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ApiUpdateCheckRuleRequest
	{
		[Preserve]
		[DataMember(Name = "action")]
		public ApiUpdateCheckAction Action { get; set; }

		[DataMember(Name = "platform")]
		[Preserve]
		public ApiUpdateCheckPlatform Platform { get; set; }

		[Preserve]
		[DataMember(Name = "version_end")]
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
