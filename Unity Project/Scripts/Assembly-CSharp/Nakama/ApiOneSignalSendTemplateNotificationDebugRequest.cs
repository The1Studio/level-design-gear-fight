using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiOneSignalSendTemplateNotificationDebugRequest
	{
		[DataMember(Name = "tags")]
		[Preserve]
		public Dictionary<string, string> Tags { get; set; }

		[DataMember(Name = "template_id")]
		[Preserve]
		public string TemplateId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
