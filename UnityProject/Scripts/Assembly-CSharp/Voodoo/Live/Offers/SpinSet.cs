using System.Collections.Generic;

namespace Voodoo.Live.Offers
{
	public class SpinSet : Feature, IFeatureSet<Spin>, IFeature, IConditionnal
	{
		public List<Spin> Features { get; set; }

		public override Reward GetReward()
		{
			return null;
		}

		public override void SetupItems(Item[] items)
		{
		}

		public override Transaction ToTransaction()
		{
			return null;
		}
	}
}
