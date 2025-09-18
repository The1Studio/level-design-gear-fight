using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class Match : IMatch
	{
		[DataMember(Name = "authoritative")]
		[Preserve]
		public bool Authoritative { get; set; }

		[Preserve]
		[DataMember(Name = "match_id")]
		public string Id { get; set; }

		[DataMember(Name = "label")]
		[Preserve]
		public string Label { get; set; }

		public IEnumerable<IUserPresence> Presences => null;

		[DataMember(Name = "presences")]
		[Preserve]
		public List<UserPresence> _presences { get; set; }

		[DataMember(Name = "size")]
		[Preserve]
		public int Size { get; set; }

		public IUserPresence Self => null;

		[Preserve]
		[DataMember(Name = "self")]
		public UserPresence _self { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
