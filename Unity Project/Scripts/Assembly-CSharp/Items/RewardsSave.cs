using System;
using System.Collections.Generic;
using Voodoo.Nakama.Data;

namespace Items
{
	[Serializable]
	public class RewardsSave : ServerBaseData
	{
		public bool Recording;

		public Dictionary<ItemNames, double> Currencies;

		public Dictionary<ItemNames, double> Gears;

		public Dictionary<ItemNames, double> Rewards;
	}
}
