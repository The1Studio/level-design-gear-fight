using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChestSyncResp
	{
		[Preserve]
		[DataMember(Name = "guild_chest_data")]
		public ApiGuildChestData GuildChestData { get; set; }

		[Preserve]
		[DataMember(Name = "request_status")]
		public ApiRequestStatus RequestStatus { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
