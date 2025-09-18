using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class GooglerpcStatus
	{
		[DataMember(Name = "code")]
		[Preserve]
		public int Code { get; set; }

		[Preserve]
		[DataMember(Name = "details")]
		public List<ProtobufAny> Details { get; set; }

		[Preserve]
		[DataMember(Name = "message")]
		public string Message { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
