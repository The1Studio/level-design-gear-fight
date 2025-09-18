using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildGiftAskResponse
	{
		[Preserve]
		[DataMember(Name = "guild_gift_data")]
		public ApiGuildGiftData GuildGiftData { get; set; }

		[Preserve]
		[DataMember(Name = "result")]
		public GuildGiftAskResponseGuildGiftAskResult Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
