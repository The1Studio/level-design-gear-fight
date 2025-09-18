using System;
using GearGame.Control;

namespace Data.Shop
{
	[Serializable]
	public struct Price
	{
		public enum Type
		{
			Currency = 0,
			Ad = 1,
			IAP = 2
		}

		public Type PriceType;

		public CurrencySO Currency;

		public int Amount;

		public string AdPlacementKey;

		public string IAPProductKey;
	}
}
