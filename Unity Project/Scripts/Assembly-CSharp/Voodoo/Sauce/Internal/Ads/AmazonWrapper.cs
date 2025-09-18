using AmazonAds;

namespace Voodoo.Sauce.Internal.Ads
{
	public static class AmazonWrapper
	{
		public delegate void AmazonInitializedCallback(string adType, object adResponse, string adNetworkData);

		private const string TAG = "AmazonWrapper";

		private const string AMAZON_AD_ERROR = "amazon_ad_error";

		private const string AMAZON_AD_RESPONSE = "amazon_ad_response";

		private static AmazonConfig _config;

		private static AmazonKey _amazonKey;

		private static AmazonConfig Config => null;

		private static bool IsEnabled()
		{
			return false;
		}

		public static void Initialize(AmazonKey amazonKey, DTBAdNetwork adNetwork)
		{
		}

		public static void InitializeBanner(AmazonInitializedCallback callback)
		{
		}

		public static void InitializeInterstitial(AmazonInitializedCallback callback)
		{
		}

		public static void InitializeRewardedVideo(AmazonInitializedCallback callback)
		{
		}
	}
}
