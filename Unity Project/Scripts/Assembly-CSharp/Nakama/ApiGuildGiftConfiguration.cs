using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildGiftConfiguration
	{
		[Preserve]
		[DataMember(Name = "gift_sent_rewards")]
		public Dictionary<string, long> GiftSentRewards { get; set; }

		[Preserve]
		[DataMember(Name = "increment")]
		public long Increment { get; set; }

		[DataMember(Name = "max_gifts_per_request")]
		[Preserve]
		public long MaxGiftsPerRequest { get; set; }

		[DataMember(Name = "request_duration_seconds")]
		[Preserve]
		public long RequestDurationSeconds { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
