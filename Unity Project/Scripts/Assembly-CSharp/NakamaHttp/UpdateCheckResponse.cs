using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class UpdateCheckResponse
	{
		[Preserve]
		[DataMember(Name = "update_url")]
		public string UpdateUrl;

		[DataMember(Name = "action")]
		[Preserve]
		public UpdateCheckAction Action;

		public UpdateCheckResponse()
		{
		}

		public UpdateCheckResponse(string updateUrlParam, UpdateCheckAction actionParam)
		{
		}
	}
}
