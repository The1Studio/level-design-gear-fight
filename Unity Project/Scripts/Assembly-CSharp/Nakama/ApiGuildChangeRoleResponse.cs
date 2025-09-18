using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChangeRoleResponse
	{
		[DataMember(Name = "guild")]
		[Preserve]
		public ApiUserGuild Guild { get; set; }

		[Preserve]
		[DataMember(Name = "result")]
		public GuildChangeRoleResponseGuildChangeRoleResult Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
