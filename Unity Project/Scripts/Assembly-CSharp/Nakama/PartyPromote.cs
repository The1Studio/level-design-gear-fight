using System.Runtime.Serialization;

namespace Nakama
{
	public class PartyPromote
	{
		[DataMember(Name = "party_id")]
		public string PartyId { get; set; }

		[DataMember(Name = "presence")]
		public UserPresence Presence { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
