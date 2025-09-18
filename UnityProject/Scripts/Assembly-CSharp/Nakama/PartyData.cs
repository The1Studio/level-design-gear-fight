using System.Runtime.Serialization;

namespace Nakama
{
	public class PartyData : IPartyData
	{
		private static readonly byte[] NoBytes;

		[Preserve]
		[DataMember(Name = "party_id")]
		public string PartyId { get; set; }

		public IUserPresence Presence => null;

		[DataMember(Name = "presence")]
		[Preserve]
		public UserPresence PresenceField { get; set; }

		public long OpCode => 0L;

		[DataMember(Name = "op_code")]
		[Preserve]
		public string OpCodeField { get; set; }

		public byte[] Data => null;

		[DataMember(Name = "data")]
		[Preserve]
		public string DataField { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
