using System;
using GearGame.Control;

namespace Data.Operations
{
	[Serializable]
	public struct CurrencyPrice
	{
		public CurrencySO Currency;

		public double Amount;
	}
}
