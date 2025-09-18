using System.Runtime.Serialization;

namespace Nakama
{
	public class PartyJoin
	{
		[Preserve]
		[DataMember(Name = "party_id")]
		public string PartyId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
