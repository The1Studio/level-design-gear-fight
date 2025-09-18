using System.Runtime.Serialization;

namespace Nakama
{
	public class MatchState : IMatchState
	{
		private static readonly byte[] NoBytes;

		[DataMember(Name = "match_id")]
		[Preserve]
		public string MatchId { get; set; }

		public long OpCode => 0L;

		[Preserve]
		[DataMember(Name = "op_code")]
		public string OpCodeField { get; set; }

		public byte[] State => null;

		[Preserve]
		[DataMember(Name = "data")]
		public string StateField { get; set; }

		public IUserPresence UserPresence => null;

		[DataMember(Name = "presence")]
		[Preserve]
		public UserPresence UserPresenceField { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
