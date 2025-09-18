using System.Collections.Generic;

namespace Voodoo.Live.Offers
{
	public class ServerNPO : ServerFeature, IServerFeatureSet, IServerFeature
	{
		public bool onePurchaseOnly;

		public bool isChained;

		public bool isEndless;

		public List<IServerFeature> Features { get; set; }

		public List<IServerFeature> GetFeature()
		{
			return null;
		}

		public override IFeature ToValidFormat()
		{
			return null;
		}
	}
}
