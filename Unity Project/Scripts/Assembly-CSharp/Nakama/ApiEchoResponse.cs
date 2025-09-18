using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiEchoResponse
	{
		[Preserve]
		[DataMember(Name = "ips")]
		public List<string> Ips { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
