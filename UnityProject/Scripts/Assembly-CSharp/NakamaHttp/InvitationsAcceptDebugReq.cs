using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class InvitationsAcceptDebugReq
	{
		[Preserve]
		[DataMember(Name = "num_accepts")]
		public int NumAccepts;

		public InvitationsAcceptDebugReq()
		{
		}

		public InvitationsAcceptDebugReq(int numAcceptsParam)
		{
		}
	}
}
