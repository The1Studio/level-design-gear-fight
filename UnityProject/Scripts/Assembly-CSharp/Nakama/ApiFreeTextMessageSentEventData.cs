using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiFreeTextMessageSentEventData
	{
		[DataMember(Name = "display_name")]
		[Preserve]
		public string DisplayName { get; set; }

		[DataMember(Name = "message")]
		[Preserve]
		public string Message { get; set; }

		[Preserve]
		[DataMember(Name = "player_id")]
		public string PlayerId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
