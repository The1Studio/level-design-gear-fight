using System.Runtime.Serialization;

namespace Nakama
{
	public class PartyDataSend
	{
		[Preserve]
		[DataMember(Name = "party_id")]
		public string PartyId { get; set; }

		[Preserve]
		[DataMember(Name = "op_code")]
		public string OpCode { get; set; }

		[DataMember(Name = "data")]
		[Preserve]
		public string Data { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
