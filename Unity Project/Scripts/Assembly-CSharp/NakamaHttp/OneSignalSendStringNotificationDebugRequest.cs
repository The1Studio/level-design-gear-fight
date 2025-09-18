using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class OneSignalSendStringNotificationDebugRequest
	{
		[Preserve]
		[DataMember(Name = "content")]
		public Dictionary<string, string> Content;

		public OneSignalSendStringNotificationDebugRequest()
		{
		}

		public OneSignalSendStringNotificationDebugRequest(Dictionary<string, string> contentParam)
		{
		}
	}
}
