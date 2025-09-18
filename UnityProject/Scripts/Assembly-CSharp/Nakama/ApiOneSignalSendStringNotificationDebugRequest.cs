using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiOneSignalSendStringNotificationDebugRequest
	{
		[DataMember(Name = "content")]
		[Preserve]
		public Dictionary<string, string> Content { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
