using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMemberGuildInfo
	{
		[DataMember(Name = "join_requests")]
		[Preserve]
		public List<ApiPlayerData> JoinRequests { get; set; }

		[DataMember(Name = "points")]
		[Preserve]
		public int Points { get; set; }

		[Preserve]
		[DataMember(Name = "role")]
		public ApiGuildRole Role { get; set; }

		[Preserve]
		[DataMember(Name = "role_change_acked")]
		public bool RoleChangeAcked { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
