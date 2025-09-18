using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class InvitationsAcceptReq
	{
		[Preserve]
		[DataMember(Name = "invite_code")]
		public string InviteCode;

		public InvitationsAcceptReq()
		{
		}

		public InvitationsAcceptReq(string inviteCodeParam)
		{
		}
	}
}
