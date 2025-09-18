using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiPreDefinedMessageSentEventData
	{
		[DataMember(Name = "display_name")]
		[Preserve]
		public string DisplayName { get; set; }

		[DataMember(Name = "message_id")]
		[Preserve]
		public int MessageId { get; set; }

		[DataMember(Name = "player_id")]
		[Preserve]
		public string PlayerId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
