using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class StreamPresenceEvent : IStreamPresenceEvent
	{
		public IEnumerable<IUserPresence> Leaves => null;

		[Preserve]
		[DataMember(Name = "leaves")]
		public List<UserPresence> LeavesField { get; set; }

		public IEnumerable<IUserPresence> Joins => null;

		[Preserve]
		[DataMember(Name = "joins")]
		public List<UserPresence> JoinsField { get; set; }

		public IStream Stream => null;

		[Preserve]
		[DataMember(Name = "stream")]
		public Stream StreamField { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
