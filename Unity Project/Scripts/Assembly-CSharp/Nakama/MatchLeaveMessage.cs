using System.Runtime.Serialization;

namespace Nakama
{
	public class MatchLeaveMessage
	{
		[Preserve]
		[DataMember(Name = "match_id")]
		public string MatchId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
