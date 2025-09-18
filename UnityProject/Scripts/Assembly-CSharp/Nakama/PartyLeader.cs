using System.Runtime.Serialization;

namespace Nakama
{
	public class PartyLeader : IPartyLeader
	{
		[Preserve]
		[DataMember(Name = "party_id")]
		public string PartyId { get; set; }

		public IUserPresence Presence => null;

		[DataMember(Name = "presence")]
		[Preserve]
		public UserPresence PresenceField { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
