using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGenericRpcMessageContainer
	{
		[DataMember(Name = "rpc")]
		[Preserve]
		public ApiRpc Rpc { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
