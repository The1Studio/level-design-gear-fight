using System.Runtime.Serialization;

namespace Nakama
{
	public class PartyMatchmakerTicket : IPartyMatchmakerTicket
	{
		[DataMember(Name = "party_id")]
		[Preserve]
		public string PartyId { get; set; }

		[Preserve]
		[DataMember(Name = "ticket")]
		public string Ticket { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
