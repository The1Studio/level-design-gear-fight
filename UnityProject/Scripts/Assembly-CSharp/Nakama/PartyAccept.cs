using System.Runtime.Serialization;

namespace Nakama
{
	public class PartyAccept
	{
		[Preserve]
		[DataMember(Name = "party_id")]
		public string PartyId { get; set; }

		[Preserve]
		[DataMember(Name = "presence")]
		public UserPresence Presence { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
