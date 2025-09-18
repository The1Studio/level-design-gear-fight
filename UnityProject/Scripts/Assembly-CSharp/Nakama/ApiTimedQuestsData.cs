using System.Runtime.Serialization;

namespace Nakama
{
	public class ApiTimedQuestsData
	{
		[Preserve]
		[DataMember(Name = "quest_id")]
		public string QuestId { get; set; }

		[Preserve]
		[DataMember(Name = "reward_id")]
		public string RewardId { get; set; }

		public override string ToString()
		{
			return null;
		}
	}
}
