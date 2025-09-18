using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class InvitationsSyncData
	{
		[Preserve]
		[DataMember(Name = "data")]
		public InvitationData Data;

		[Preserve]
		[DataMember(Name = "claimed_join_reward")]
		public bool ClaimedJoinReward;

		public InvitationsSyncData()
		{
		}

		public InvitationsSyncData(InvitationData dataParam, bool claimedJoinRewardParam)
		{
		}
	}
}
