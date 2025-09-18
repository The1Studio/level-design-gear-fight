using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiFriendList
	{
		[Preserve]
		[DataMember(Name = "cursor")]
		public string Cursor { get; set; }

		[Preserve]
		[DataMember(Name = "friends")]
		public List<ApiFriend> Friends { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
