using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class InvitationsSyncResp
	{
		[DataMember(Name = "data")]
		[Preserve]
		public InvitationsSyncData Data;

		[DataMember(Name = "enabled")]
		[Preserve]
		public bool Enabled;

		public InvitationsSyncResp()
		{
		}

		public InvitationsSyncResp(InvitationsSyncData dataParam, bool enabledParam)
		{
		}
	}
}
