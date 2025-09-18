using UnityEngine;

namespace Voodoo.Sauce.Internal.Ads
{
	public class MaxNativeAdsSdkAndroid
	{
		private class NativeAdsCallbackProxy : AndroidJavaProxy
		{
			public NativeAdsCallbackProxy()
				: base((string)null)
			{
			}

			public void onEvent(string propsStr)
			{
			}
		}

		private static readonly AndroidJavaClass MaxNativeAdsPluginClass;

		private static readonly NativeAdsCallbackProxy NativeAdsCallback;

		static MaxNativeAdsSdkAndroid()
		{
		}

		public static void Initialize(string adUnitId)
		{
		}

		public static void LoadAd()
		{
		}

		public static bool IsAdReadyToShow()
		{
			return false;
		}

		public static void ShowAd(string adPlacement, float x, float y, float width, float height)
		{
		}

		public static void HideAd()
		{
		}

		public static void SetCustomData(string customData)
		{
		}
	}
}
