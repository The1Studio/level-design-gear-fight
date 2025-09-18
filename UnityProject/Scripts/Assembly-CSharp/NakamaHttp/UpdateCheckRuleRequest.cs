using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class UpdateCheckRuleRequest
	{
		[Preserve]
		[DataMember(Name = "platform")]
		public UpdateCheckPlatform Platform;

		[Preserve]
		[DataMember(Name = "version_start")]
		public string VersionStart;

		[Preserve]
		[DataMember(Name = "version_end")]
		public string VersionEnd;

		[DataMember(Name = "action")]
		[Preserve]
		public UpdateCheckAction Action;

		public UpdateCheckRuleRequest()
		{
		}

		public UpdateCheckRuleRequest(UpdateCheckPlatform platformParam, string versionStartParam, string versionEndParam, UpdateCheckAction actionParam)
		{
		}
	}
}
