using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAbTestCreateVersionDebugReq
	{
		[Preserve]
		[DataMember(Name = "cases")]
		public List<ApiAbTestCase> Cases { get; set; }

		[DataMember(Name = "name")]
		[Preserve]
		public string Name { get; set; }

		[DataMember(Name = "salt")]
		[Preserve]
		public string Salt { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
