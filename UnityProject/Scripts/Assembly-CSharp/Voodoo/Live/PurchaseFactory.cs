using System;

namespace Voodoo.Live
{
	public static class PurchaseFactory
	{
		public static Func<string, int, bool> currencyAvailability;

		public static Action<string, int> currencyDebit;

		public static Action<string> purchaseIAP;

		public static IPurchasable Create(IPrice price)
		{
			return null;
		}

		public static void DefaultIAPPurchase(string productId)
		{
		}
	}
}
