using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMarbleSquidGameGuessOddOrEvenReq
	{
		[Preserve]
		[DataMember(Name = "match_id")]
		public string MatchId { get; set; }

		[Preserve]
		[DataMember(Name = "was_odd")]
		public bool WasOdd { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
