using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildAckRoleOrStateChangeResp
	{
		[Preserve]
		[DataMember(Name = "guild")]
		public ApiUserGuild Guild { get; set; }

		[Preserve]
		[DataMember(Name = "result")]
		public GuildAckRoleOrStateChangeRespGuildAckRoleOrStateChangeResult Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
