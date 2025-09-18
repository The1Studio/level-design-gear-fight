using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class ConsoleCallApiEndpointRequest
	{
		[DataMember(Name = "body")]
		[Preserve]
		public string Body { get; set; }

		[Preserve]
		[DataMember(Name = "rpc_method")]
		public string RpcMethod { get; set; }

		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
