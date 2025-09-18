using System.Collections.Generic;

namespace Voodoo.Live.Offers
{
	public class NPO : Feature, IFeatureSet, IFeature, IConditionnal
	{
		public bool onePurchaseOnly;

		public bool isChained;

		public bool isEndless;

		public List<IFeature> Features { get; set; }

		public Feature SelectedFeature { get; private set; }

		public override Reward GetReward()
		{
			return null;
		}

		public override Transaction ToTransaction()
		{
			return null;
		}

		public override void SetupItems(Item[] items)
		{
		}
	}
}
