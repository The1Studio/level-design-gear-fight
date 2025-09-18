using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiAddFriendsRequest
	{
		[DataMember(Name = "ids")]
		[Preserve]
		public List<string> Ids { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
