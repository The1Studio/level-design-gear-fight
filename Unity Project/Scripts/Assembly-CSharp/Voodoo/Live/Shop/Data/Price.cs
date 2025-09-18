using System;

namespace Voodoo.Live.Shop.Data
{
	[Serializable]
	public class Price
	{
		public string type;

		public string appleProductId;

		public string androidProductId;

		public string currencyType;

		public int amount;

		public string GetProductIAPId()
		{
			return null;
		}
	}
}
