using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildJoinResponse
	{
		[DataMember(Name = "guild")]
		[Preserve]
		public ApiUserGuild Guild { get; set; }

		[DataMember(Name = "result")]
		[Preserve]
		public GuildJoinResponseGuildJoinResult Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
