using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class InvitationsAcceptResp
	{
		[Preserve]
		[DataMember(Name = "data")]
		public InvitationsAcceptData Data;

		[Preserve]
		[DataMember(Name = "enabled")]
		public bool Enabled;

		public InvitationsAcceptResp()
		{
		}

		public InvitationsAcceptResp(InvitationsAcceptData dataParam, bool enabledParam)
		{
		}
	}
}
