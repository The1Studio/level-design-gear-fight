using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiGodTierInviteUsersDebugResp
	{
		[Preserve]
		[DataMember(Name = "success")]
		public bool Success { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
