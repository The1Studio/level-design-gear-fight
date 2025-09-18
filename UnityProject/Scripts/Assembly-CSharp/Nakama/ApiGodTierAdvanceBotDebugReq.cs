using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierAdvanceBotDebugReq
	{
		[Preserve]
		[DataMember(Name = "bot_user_id")]
		public string BotUserId { get; set; }

		[Preserve]
		[DataMember(Name = "event_id")]
		public string EventId { get; set; }

		[Preserve]
		[DataMember(Name = "new_bot_score")]
		public int NewBotScore { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
