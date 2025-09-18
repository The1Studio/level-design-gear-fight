using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class GenericRpcMessageContainer
	{
		[DataMember(Name = "rpc")]
		[Preserve]
		public Rpc Rpc;

		public GenericRpcMessageContainer()
		{
		}

		public GenericRpcMessageContainer(Rpc rpcParam)
		{
		}
	}
}
