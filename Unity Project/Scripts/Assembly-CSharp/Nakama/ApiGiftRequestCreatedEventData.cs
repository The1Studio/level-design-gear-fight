using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGiftRequestCreatedEventData
	{
		[DataMember(Name = "display_name")]
		[Preserve]
		public string DisplayName { get; set; }

		[Preserve]
		[DataMember(Name = "gift_request_id")]
		public string GiftRequestId { get; set; }

		[DataMember(Name = "gift_type")]
		[Preserve]
		public string GiftType { get; set; }

		[DataMember(Name = "max_gifts")]
		[Preserve]
		public long MaxGifts { get; set; }

		[DataMember(Name = "player_id")]
		[Preserve]
		public string PlayerId { get; set; }

		[DataMember(Name = "received_gifts")]
		[Preserve]
		public long ReceivedGifts { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
