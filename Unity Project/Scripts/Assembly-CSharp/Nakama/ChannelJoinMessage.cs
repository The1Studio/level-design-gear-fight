using System.Runtime.Serialization;

namespace Nakama
{
	public class ChannelJoinMessage
	{
		[DataMember(Name = "hidden")]
		[Preserve]
		public bool Hidden { get; set; }

		[DataMember(Name = "persistence")]
		[Preserve]
		public bool Persistence { get; set; }

		[DataMember(Name = "target")]
		[Preserve]
		public string Target { get; set; }

		[DataMember(Name = "type")]
		[Preserve]
		public int Type { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
