using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildSyncResponse
	{
		[Preserve]
		[DataMember(Name = "guild")]
		public ApiUserGuild Guild { get; set; }

		[DataMember(Name = "result")]
		[Preserve]
		public GuildSyncResponseGuildSyncResult Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
