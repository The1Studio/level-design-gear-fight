using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildGiftHelpRequest
	{
		[DataMember(Name = "display_name")]
		[Preserve]
		public string DisplayName { get; set; }

		[Preserve]
		[DataMember(Name = "gift_type")]
		public string GiftType { get; set; }

		[DataMember(Name = "id")]
		[Preserve]
		public string Id { get; set; }

		[DataMember(Name = "max_gifts")]
		[Preserve]
		public long MaxGifts { get; set; }

		[DataMember(Name = "received_gifts")]
		[Preserve]
		public long ReceivedGifts { get; set; }

		[Preserve]
		[DataMember(Name = "seconds_until_next_request")]
		public long SecondsUntilNextRequest { get; set; }

		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
