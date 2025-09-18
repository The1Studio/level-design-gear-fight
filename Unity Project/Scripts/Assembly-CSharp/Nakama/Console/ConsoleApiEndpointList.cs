using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleApiEndpointList
	{
		[Preserve]
		[DataMember(Name = "endpoints")]
		public List<ConsoleApiEndpointDescriptor> Endpoints { get; set; }

		[Preserve]
		[DataMember(Name = "rpc_endpoints")]
		public List<ConsoleApiEndpointDescriptor> RpcEndpoints { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
