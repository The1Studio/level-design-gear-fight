using UnityEngine;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class AnalyticsSettings : ScriptableObject
	{
		public const string NAME = "AnalyticsSettings";

		public const string RelativePathFromResources = "VSSettings/";

		public const string RelativePath = "Assets/Resources/VSSettings/";

		public string platform;

		public string store;

		public bool useFirebaseAnalytics;

		public bool useRemoteConfig;

		public string adjustAppToken;

		public string noAdsBundleId;

		public bool useVoodooAnalytics;

		public ConversionEventsSettings conversionEvents;

		public bool isChinaStore;

		public string appleStoreId;

		public VoodooFunnelsSettings voodooFunnels;

		public string gameAnalyticsGameKey;

		public string gameAnalyticsSecretKey;

		public bool excludeGameAnalyticsSDK;

		[ReadOnly]
		public string facebookAppId;

		private static AnalyticsSettings _settings;

		public static string GetRelativePath()
		{
			return null;
		}

		public static string GetRelativePathFromResources()
		{
			return null;
		}

		public static string NameByPlatformAndStore(string platform, string store)
		{
			return null;
		}

		public static string GetRelativePathByPlatformAndStore(string platform, string store)
		{
			return null;
		}

		public static string GetRelativePathFromResourcesByPlatformAndStore(string platform, string store)
		{
			return null;
		}

		public static AnalyticsSettings Load()
		{
			return null;
		}

		public static AnalyticsSettings Load(string platformToLoad, string storeToLoad)
		{
			return null;
		}

		public static AnalyticsSettings RuntimeLoad()
		{
			return null;
		}
	}
}
