using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGuildChangeUserStateResp
	{
		[Preserve]
		[DataMember(Name = "guild")]
		public ApiUserGuild Guild { get; set; }

		[DataMember(Name = "result")]
		[Preserve]
		public GuildChangeUserStateRespGuildChangeUserStateResult Result { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
