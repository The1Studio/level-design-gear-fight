using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMatch
	{
		[Preserve]
		[DataMember(Name = "authoritative")]
		public bool Authoritative { get; set; }

		[Preserve]
		[DataMember(Name = "handler_name")]
		public string HandlerName { get; set; }

		[Preserve]
		[DataMember(Name = "label")]
		public string Label { get; set; }

		[DataMember(Name = "match_id")]
		[Preserve]
		public string MatchId { get; set; }

		[DataMember(Name = "size")]
		[Preserve]
		public int Size { get; set; }

		[Preserve]
		[DataMember(Name = "tick_rate")]
		public int TickRate { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
