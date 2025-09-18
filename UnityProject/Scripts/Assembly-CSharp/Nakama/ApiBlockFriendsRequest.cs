using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiBlockFriendsRequest
	{
		[Preserve]
		[DataMember(Name = "ids")]
		public List<string> Ids { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
