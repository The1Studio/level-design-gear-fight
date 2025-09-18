using System;

namespace Voodoo.Sauce.Internal.Ads
{
	internal static class VoodooPremium
	{
		private const string TAG = "VoodooPremium";

		private const string PREFS_PREMIUM = "VoodooSauce.Premium";

		private const string PREMIUM_PERIOD = "VoodooSauce.PremiumPeriod";

		private const string SUPER_PREMIUM = "super_premium";

		internal static bool IsNoAdsPremium()
		{
			return false;
		}

		internal static bool HasPremiumPeriod()
		{
			return false;
		}

		internal static bool IsPremium()
		{
			return false;
		}

		internal static bool IsSuperPremium()
		{
			return false;
		}

		public static void InitializeWithSuperPremium(bool superPremium)
		{
		}

		public static void SetPremiumPeriod(bool isPremiumPeriodActive)
		{
		}

		public static void EnablePremium()
		{
		}

		public static void DisablePremium()
		{
		}

		private static void EnablePremiumPeriod()
		{
		}

		private static void DisablePremiumPeriod()
		{
		}

		public static void SubscribeToPremiumStatusChange(Action<bool> callback)
		{
		}
	}
}
