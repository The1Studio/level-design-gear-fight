using System;

namespace Voodoo.Live.Offers
{
	public interface IFeature : IConditionnal
	{
		string id { get; set; }

		string name { get; set; }

		string[] triggers { get; set; }

		int multiplier { get; set; }

		string campaign { get; set; }

		FeatureVisual visual { get; set; }

		string type { get; set; }

		bool IsDataValid { get; }

		bool ShouldDisplayBadges { get; }

		bool IsPurchaseStarting { get; }

		bool IsPurchaseCompleting { get; }

		string Status { get; }

		event Action<string, IFeature> statusChanged;

		void SetupItems(Item[] items);

		void SetStatus(string status);

		bool HasTrigger(string trigger);

		bool TryTrigger(string trigger, bool forceTrigger = false);

		Reward GetReward();

		Transaction ToTransaction();
	}
}
