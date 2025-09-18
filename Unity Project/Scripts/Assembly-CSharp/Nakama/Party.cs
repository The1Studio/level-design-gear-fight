using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class Party : IParty
	{
		[Preserve]
		[DataMember(Name = "party_id")]
		public string Id { get; set; }

		[DataMember(Name = "open")]
		[Preserve]
		public bool Open { get; set; }

		[DataMember(Name = "max_size")]
		[Preserve]
		public int MaxSize { get; set; }

		public IUserPresence Self => null;

		[DataMember(Name = "self")]
		[Preserve]
		public UserPresence SelfField { get; set; }

		public IUserPresence Leader => null;

		[DataMember(Name = "leader")]
		[Preserve]
		public UserPresence LeaderField { get; set; }

		public IEnumerable<IUserPresence> Presences => null;

		[Preserve]
		[DataMember(Name = "presences")]
		public List<UserPresence> PresencesField { get; set; }
	}
}
