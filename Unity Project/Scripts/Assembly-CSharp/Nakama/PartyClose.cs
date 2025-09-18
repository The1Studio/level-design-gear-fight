using System.Runtime.Serialization;

namespace Nakama
{
	public class PartyClose : IPartyClose
	{
		[DataMember(Name = "party_id")]
		[Preserve]
		public string PartyId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
