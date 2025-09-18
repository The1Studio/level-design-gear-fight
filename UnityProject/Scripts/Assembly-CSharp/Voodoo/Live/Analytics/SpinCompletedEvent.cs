using System.Collections.Generic;

namespace Voodoo.Live.Analytics
{
	public class SpinCompletedEvent : SpinEvent
	{
		private const string Spin_Probabilities = "spin_probabilities";

		private const string Spin_Count = "spin_count_since_offer_opened";

		private const string Feature_Id = "feature_id";

		private const string Reward_Id = "reward_id";

		private const string Reward_Name = "reward_name";

		private readonly string _probabilities;

		private readonly string _spinCount;

		private readonly string _featureId;

		private readonly string _rewardId;

		private readonly string _rewardName;

		private static string eventName;

		public SpinCompletedEvent(string offerId, string probabilities, string spinCount, string featureId, string rewardId, string rewardName)
			: base(null, null)
		{
		}

		protected override void AddParameters(Dictionary<string, object> parameters)
		{
		}
	}
}
