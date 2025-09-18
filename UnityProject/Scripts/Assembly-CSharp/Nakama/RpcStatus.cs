using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class RpcStatus
	{
		[Preserve]
		[DataMember(Name = "code")]
		public int Code { get; set; }

		[Preserve]
		[DataMember(Name = "details")]
		public List<ProtobufAny> Details { get; set; }

		[DataMember(Name = "message")]
		[Preserve]
		public string Message { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
