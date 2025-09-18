using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMarbleSquidGamePickMarblesReq
	{
		[DataMember(Name = "marble_count")]
		[Preserve]
		public int MarbleCount { get; set; }

		[DataMember(Name = "match_id")]
		[Preserve]
		public string MatchId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
