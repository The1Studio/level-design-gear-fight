using System.Runtime.Serialization;

namespace NakamaHttp
{
	public class CollectConfiguration
	{
		[DataMember(Name = "title")]
		[Preserve]
		public string Title;

		[DataMember(Name = "challenge_name")]
		[Preserve]
		public string ChallengeName;

		[DataMember(Name = "reward_name")]
		[Preserve]
		public string RewardName;

		[DataMember(Name = "resource_name")]
		[Preserve]
		public string ResourceName;

		[DataMember(Name = "event_config")]
		[Preserve]
		public string EventConfig;

		[DataMember(Name = "reward_type")]
		[Preserve]
		public string RewardType;

		[DataMember(Name = "icon")]
		[Preserve]
		public string Icon;

		[DataMember(Name = "background")]
		[Preserve]
		public string Background;

		[DataMember(Name = "gradient1")]
		[Preserve]
		public string Gradient1;

		[DataMember(Name = "gradient2")]
		[Preserve]
		public string Gradient2;

		[DataMember(Name = "min_diorama_index")]
		[Preserve]
		public int MinDioramaIndex;

		[DataMember(Name = "forced_small_challenges_amount")]
		[Preserve]
		public int ForcedSmallChallengesAmount;

		public CollectConfiguration()
		{
		}

		public CollectConfiguration(string titleParam, string challengeNameParam, string rewardNameParam, string resourceNameParam, string eventConfigParam, string rewardTypeParam, string iconParam, string backgroundParam, string gradient1Param, string gradient2Param, int minDioramaIndexParam, int forcedSmallChallengesAmountParam)
		{
		}
	}
}
