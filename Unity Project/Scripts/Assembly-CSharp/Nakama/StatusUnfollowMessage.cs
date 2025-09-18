using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class StatusUnfollowMessage
	{
		[DataMember(Name = "user_ids")]
		[Preserve]
		public List<string> UserIds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
