using System;
using System.Collections.Generic;
using Voodoo.Sauce.IAP.Settings;
using Voodoo.Sauce.Internal.IntegrationCheck;

namespace Voodoo.Sauce.IAP
{
	internal class IAPIntegrationCheck
	{
		private const string SETTINGS_WRONG_ANDROID_PRODUCT_ID_WARNING = "\n INVALID PRODUCT ID DETECTED \n\n Android product ids may only contain numbers, lowercase letters, underscores, and periods. \n\n The following product IDs will automatically be changed to conform to Android's naming rules: \n\n\n";

		private const string GOOGLE_STORE_KEY_NOT_OBFUSCATED_ERROR = "GooglePlay Store Key has not been obfuscated. If you wish to publish your app with IAP purchases on Android, you MUST obfuscate your google key by going to {0}. If this is your first build, you can ignore this message and send this build on the Google Play Store";

		private static readonly string IgnoringGooglePlayStoreKeyNotObfuscatedWarning;

		private const string OBFUSCATION_MENU = "Window > UnityIAP > Receipt Validation Obfuscator";

		private const string OBFUSCATION_MENU_V3 = "Services > In-App Purchasing > Receipt Validation Obfuscator";

		private const string UNITY_IAP_MISSING = "Unity In-App Purchase package is missing. If you want to use IAP on your game correctly, you need it.";

		private const string UNITY_IAP_TOO_OLD = "The Unity In-App Purchase package version you use is too old. Please update it at least to v4.9.4.";

		private const string MISSING_NO_ADS_PRODUCT_ID = "The IAP module is enabled for the {0} platform and its corresponding NoAds productId is empty. It will not work during play mode. Please ensure that this is done on purpose before releasing this build.";

		private const string MISSING_SHARED_SECRET_KEY = "Your Apple Shared Secret Key is empty. You need it to validate the subscriptions that will be done in your app. Please add it in your VoodooSettings in the 'Subscription Shared Key' field";

		private static string GooglePlayTanglePathV2 => null;

		private static string GooglePlayTanglePathV3 => null;

		public List<IntegrationCheckMessage> IntegrationCheck(IAPInitializationState initializationState)
		{
			return null;
		}

		private void CheckUnityIAPVersion(List<IntegrationCheckMessage> messages)
		{
		}

		private Version GetUnityIapVersion()
		{
			return null;
		}

		private void CheckEmptySharedSecretKey(IAPSettings settings, List<IntegrationCheckMessage> messages)
		{
		}

		private void CheckNoAdsProductId(IAPSettings settings, List<IntegrationCheckMessage> messages)
		{
		}

		private void CheckProductIds(IAPSettings settings, List<IntegrationCheckMessage> messages)
		{
		}

		private void CheckGoogleTangle(IAPSettings settings, List<IntegrationCheckMessage> messages)
		{
		}

		private bool IsGooglePlayTanglePopulated()
		{
			return false;
		}

		private bool IsGooglePlayTanglePopulated(string path)
		{
			return false;
		}
	}
}
