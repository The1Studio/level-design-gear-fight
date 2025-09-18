using System.Runtime.Serialization;

namespace Nakama
{
	public class PartyMatchmakerRemove
	{
		[Preserve]
		[DataMember(Name = "party_id")]
		public string PartyId { get; set; }

		[DataMember(Name = "ticket")]
		[Preserve]
		public string Ticket { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
