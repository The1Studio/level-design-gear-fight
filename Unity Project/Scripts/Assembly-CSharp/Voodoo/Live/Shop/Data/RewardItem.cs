using System;
using Newtonsoft.Json;

namespace Voodoo.Live.Shop.Data
{
	[Serializable]
	public class RewardItem
	{
		public string id;

		public string name;

		public int quantity;

		public SpriteData sprite;

		[JsonConstructor]
		public RewardItem(string id, string name, int quantity)
		{
		}
	}
}
