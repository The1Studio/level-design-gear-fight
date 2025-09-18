using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierSetCurrentGodsDebugReq
	{
		[Preserve]
		[DataMember(Name = "user_ids")]
		public List<string> UserIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
