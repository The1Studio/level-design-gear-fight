using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class InvitationsAcceptData
	{
		[DataMember(Name = "data")]
		[Preserve]
		public InvitationData Data;

		[DataMember(Name = "success")]
		[Preserve]
		public bool Success;

		public InvitationsAcceptData()
		{
		}

		public InvitationsAcceptData(InvitationData dataParam, bool successParam)
		{
		}
	}
}
