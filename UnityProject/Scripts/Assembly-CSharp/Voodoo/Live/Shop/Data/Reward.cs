using System;
using System.Collections.Generic;

namespace Voodoo.Live.Shop.Data
{
	[Serializable]
	public class Reward
	{
		public string id;

		public string name;

		public List<RewardItem> items;

		public SpriteData sprite;
	}
}
