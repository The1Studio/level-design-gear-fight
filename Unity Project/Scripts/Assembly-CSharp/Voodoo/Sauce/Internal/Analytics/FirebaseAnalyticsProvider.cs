using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Preserve]
	internal class FirebaseAnalyticsProvider : BaseAnalyticsProviderWithLogger
	{
		private readonly bool _useFirebaseAnalytics;

		private static string _mediation;

		internal override VoodooSauce.AnalyticsProvider GetProviderEnum()
		{
			return default(VoodooSauce.AnalyticsProvider);
		}

		public FirebaseAnalyticsProvider()
		{
		}

		internal FirebaseAnalyticsProvider(bool useFirebaseAnalytics, string mediation)
		{
		}

		public override void Instantiate(string mediation)
		{
		}

		public override void Initialize(AnalyticsProviderInfo info)
		{
		}

		private static void RegisterEvents()
		{
		}

		private static void UnregisterEvents()
		{
		}

		private static void OnGameStarted(GameStartedParameters parameters)
		{
		}

		private static void OnGameFinished(GameFinishedParameters parameters)
		{
		}

		private static void TrackCustomEvent(string eventName, Dictionary<string, object> eventProperties, string type, List<VoodooSauce.AnalyticsProvider> analyticsProviders, Dictionary<string, object> contextVariables = null)
		{
		}

		private static void TrackPurchase(IIAPCommonInfo purchaseInfo)
		{
		}

		private static void OnFsShown(AdShownEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnRvShown(AdShownEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnBannerClicked(AdEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnFsClicked(AdClickEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnRvClicked(AdClickEventAnalyticsInfo adAnalyticsInfo)
		{
		}

		private static void OnImpressionTrackedEvent(ImpressionAnalyticsInfo impressionInfo)
		{
		}
	}
}
