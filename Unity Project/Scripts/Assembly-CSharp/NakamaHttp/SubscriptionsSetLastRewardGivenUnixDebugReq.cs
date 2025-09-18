using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class SubscriptionsSetLastRewardGivenUnixDebugReq
	{
		[DataMember(Name = "last_given_unix")]
		[Preserve]
		public int LastGivenUnix;

		public SubscriptionsSetLastRewardGivenUnixDebugReq()
		{
		}

		public SubscriptionsSetLastRewardGivenUnixDebugReq(int lastGivenUnixParam)
		{
		}
	}
}
