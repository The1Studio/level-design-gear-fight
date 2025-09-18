using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiUserGuild
	{
		[DataMember(Name = "guild")]
		[Preserve]
		public ApiGuild Guild { get; set; }

		[Preserve]
		[DataMember(Name = "is_member")]
		public bool IsMember { get; set; }

		[Preserve]
		[DataMember(Name = "member_guild_info")]
		public ApiMemberGuildInfo MemberGuildInfo { get; set; }

		[Preserve]
		[DataMember(Name = "non_member_guild_info")]
		public ApiNonMemberGuildInfo NonMemberGuildInfo { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
