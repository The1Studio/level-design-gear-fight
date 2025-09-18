using System.Collections.Generic;
using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class InvitationData
	{
		[Preserve]
		[DataMember(Name = "rewards")]
		public Dictionary<int, InvitationRewardItem> Rewards;

		[DataMember(Name = "invite_code")]
		[Preserve]
		public string InviteCode;

		[Preserve]
		[DataMember(Name = "can_claim_code")]
		public bool CanClaimCode;

		[DataMember(Name = "invited_players")]
		[Preserve]
		public int InvitedPlayers;

		[DataMember(Name = "highest_claimed_invited_player")]
		[Preserve]
		public int HighestClaimedInvitedPlayer;

		public InvitationData()
		{
		}

		public InvitationData(Dictionary<int, InvitationRewardItem> rewardsParam, string inviteCodeParam, bool canClaimCodeParam, int invitedPlayersParam, int highestClaimedInvitedPlayerParam)
		{
		}
	}
}
