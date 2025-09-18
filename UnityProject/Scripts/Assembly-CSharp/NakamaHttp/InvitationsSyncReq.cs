using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class InvitationsSyncReq
	{
		[Preserve]
		[DataMember(Name = "acked_join_reward")]
		public bool AckedJoinReward;

		[Preserve]
		[DataMember(Name = "highest_acked_invited_player")]
		public int HighestAckedInvitedPlayer;

		public InvitationsSyncReq()
		{
		}

		public InvitationsSyncReq(bool ackedJoinRewardParam, int highestAckedInvitedPlayerParam)
		{
		}
	}
}
