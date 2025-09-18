using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class OneSignalSendTemplateNotificationDebugRequest
	{
		[DataMember(Name = "tags")]
		[Preserve]
		public Dictionary<string, string> Tags;

		[DataMember(Name = "template_id")]
		[Preserve]
		public string TemplateId;

		public OneSignalSendTemplateNotificationDebugRequest()
		{
		}

		public OneSignalSendTemplateNotificationDebugRequest(Dictionary<string, string> tagsParam, string templateIdParam)
		{
		}
	}
}
