using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class EchoResponse
	{
		[DataMember(Name = "ips")]
		[Preserve]
		public List<string> Ips;

		public EchoResponse()
		{
		}

		public EchoResponse(List<string> ipsParam)
		{
		}
	}
}
