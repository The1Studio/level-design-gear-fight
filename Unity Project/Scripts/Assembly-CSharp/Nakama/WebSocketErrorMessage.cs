using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class WebSocketErrorMessage
	{
		[Preserve]
		[DataMember(Name = "code")]
		public int Code { get; set; }

		[Preserve]
		[DataMember(Name = "context")]
		public Dictionary<string, string> Context { get; set; }

		[DataMember(Name = "message")]
		[Preserve]
		public string Message { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
