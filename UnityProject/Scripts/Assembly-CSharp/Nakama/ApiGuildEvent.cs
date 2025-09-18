using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildEvent
	{
		[Preserve]
		[DataMember(Name = "created_at_timestamp")]
		public long CreatedAtTimestamp { get; set; }

		[Preserve]
		[DataMember(Name = "free_text_message_event_data")]
		public ApiFreeTextMessageSentEventData FreeTextMessageEventData { get; set; }

		[Preserve]
		[DataMember(Name = "gift_request_created_event_data")]
		public ApiGiftRequestCreatedEventData GiftRequestCreatedEventData { get; set; }

		[DataMember(Name = "player_joined_event_data")]
		[Preserve]
		public ApiPlayerJoinedEventData PlayerJoinedEventData { get; set; }

		[DataMember(Name = "player_left_event_data")]
		[Preserve]
		public ApiPlayerLeftEventData PlayerLeftEventData { get; set; }

		[DataMember(Name = "pre_defined_message_event_data")]
		[Preserve]
		public ApiPreDefinedMessageSentEventData PreDefinedMessageEventData { get; set; }

		[DataMember(Name = "type")]
		[Preserve]
		public ApiGuildEventType Type { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
