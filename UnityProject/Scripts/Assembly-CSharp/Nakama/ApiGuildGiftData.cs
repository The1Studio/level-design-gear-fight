using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildGiftData
	{
		[DataMember(Name = "config")]
		[Preserve]
		public Dictionary<string, ApiGuildGiftConfiguration> Config { get; set; }

		[Preserve]
		[DataMember(Name = "currently_active_user_requests")]
		public List<ApiGuildGiftHelpRequest> CurrentlyActiveUserRequests { get; set; }

		[DataMember(Name = "pending_requests_oldest_first")]
		[Preserve]
		public List<ApiGuildGiftHelpRequest> PendingRequestsOldestFirst { get; set; }

		[DataMember(Name = "received_gifts")]
		[Preserve]
		public List<ApiGuildGift> ReceivedGifts { get; set; }

		[DataMember(Name = "seconds_until_next_request")]
		[Preserve]
		public Dictionary<string, long> SecondsUntilNextRequest { get; set; }

		[DataMember(Name = "user_guild_id")]
		[Preserve]
		public string UserGuildId { get; set; }

		[DataMember(Name = "user_total_gift_counter")]
		[Preserve]
		public Dictionary<string, ApiGuildGiftTotalPerUser> UserTotalGiftCounter { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
