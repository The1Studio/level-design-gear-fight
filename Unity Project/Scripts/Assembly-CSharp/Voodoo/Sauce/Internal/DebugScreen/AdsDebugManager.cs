using System;

namespace Voodoo.Sauce.Internal.DebugScreen
{
	public static class AdsDebugManager
	{
		private const string SHOW_INTERSTITIAL_AD_BADGE_KEY = "Voodoo_DebugFSBadge";

		private const string SHOW_REWARDED_VIDEO_AD_BADGE_KEY = "Voodoo_DebugRVBadge";

		private const int DEFAULT_ENABLED_VALUE = 1;

		private static bool _initialized;

		public static Action interstitialAdStateBadgeChanged;

		public static Action rewardedVideoAdStateBadgeChanged;

		private static bool _isInterstitialAdStateBadgeEnabled;

		private static bool _isRewardedVideoAdStateBadgeEnabled;

		public static bool IsInterstitialAdStateBadgeEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static bool IsRewardedVideoAdStateBadgeEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private static void Initialize()
		{
		}
	}
}
