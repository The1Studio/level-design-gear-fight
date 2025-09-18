using System;
using Newtonsoft.Json;
using Voodoo.Tune.Core;

namespace Voodoo.Live.Offers
{
	[Serializable]
	public class FeatureConfig
	{
		public Item[] items;

		public IServerFeature[] offers;

		public VoodooConfig config;

		public FeatureConfig()
		{
		}

		[JsonConstructor]
		public FeatureConfig(IServerFeature[] offers, Item[] items, VoodooConfig Voodoo_Config)
		{
		}
	}
}
