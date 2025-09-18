using System.Collections.Generic;

namespace Voodoo.Live.Analytics
{
	public class SpinPayClickedEvent : SpinEvent
	{
		private const string Spin_Count = "spin_count_since_offer_opened";

		private const string Feature_Id = "feature_id";

		private const string Reward_Id = "reward_id";

		private const string Reward_Name = "reward_name";

		private readonly string _spinCount;

		private readonly string _featureId;

		private readonly string _rewardId;

		private readonly string _rewardName;

		private static string eventName => null;

		public SpinPayClickedEvent(string offerId, string spinCount, string featureId, string rewardId, string rewardName)
			: base(null, null)
		{
		}

		protected override void AddParameters(Dictionary<string, object> parameters)
		{
		}
	}
}
