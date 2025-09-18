using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class UpdateCheckRequest
	{
		[DataMember(Name = "platform")]
		[Preserve]
		public UpdateCheckPlatform Platform;

		[Preserve]
		[DataMember(Name = "current_version")]
		public string CurrentVersion;

		public UpdateCheckRequest()
		{
		}

		public UpdateCheckRequest(UpdateCheckPlatform platformParam, string currentVersionParam)
		{
		}
	}
}
