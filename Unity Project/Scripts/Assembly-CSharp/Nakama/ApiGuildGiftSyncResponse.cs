using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildGiftSyncResponse
	{
		[Preserve]
		[DataMember(Name = "guild_gift_data")]
		public ApiGuildGiftData GuildGiftData { get; set; }

		[Preserve]
		[DataMember(Name = "result")]
		public GuildGiftSyncResponseGuildGiftSyncResult Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
