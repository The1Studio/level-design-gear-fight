using System.Runtime.Serialization;

namespace Nakama.Console
{
	public class NakamaapiMatch
	{
		[DataMember(Name = "authoritative")]
		[Preserve]
		public bool Authoritative { get; set; }

		[Preserve]
		[DataMember(Name = "handler_name")]
		public string HandlerName { get; set; }

		[DataMember(Name = "label")]
		[Preserve]
		public string Label { get; set; }

		[DataMember(Name = "match_id")]
		[Preserve]
		public string MatchId { get; set; }

		[DataMember(Name = "size")]
		[Preserve]
		public int Size { get; set; }

		[DataMember(Name = "tick_rate")]
		[Preserve]
		public int TickRate { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
