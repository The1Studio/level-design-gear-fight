using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiMocPvpAddFutureOpponentDebugReq
	{
		[Preserve]
		[DataMember(Name = "config_id")]
		public string ConfigId { get; set; }

		[Preserve]
		[DataMember(Name = "opponent_user_id")]
		public string OpponentUserId { get; set; }

		[DataMember(Name = "user_id")]
		[Preserve]
		public string UserId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
