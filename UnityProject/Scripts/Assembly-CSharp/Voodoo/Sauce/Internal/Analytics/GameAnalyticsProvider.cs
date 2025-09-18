using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Preserve]
	internal class GameAnalyticsProvider : BaseAnalyticsProviderWithLogger
	{
		internal override VoodooSauce.AnalyticsProvider GetProviderEnum()
		{
			return default(VoodooSauce.AnalyticsProvider);
		}

		public GameAnalyticsProvider()
		{
		}

		internal GameAnalyticsProvider(bool initEvents)
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

		private static void TrackPurchase(IIAPCommonInfo purchaseInfo)
		{
		}

		private static void OnGameFinished(GameFinishedParameters parameters)
		{
		}

		private static void TrackCustomEvent(string eventName, Dictionary<string, object> eventProperties, string type, List<VoodooSauce.AnalyticsProvider> analyticsProviders, Dictionary<string, object> contextVariables = null)
		{
		}

		private static Dictionary<string, object> MergeContexts(Dictionary<string, object> context, Dictionary<string, object> legacyContext)
		{
			return null;
		}
	}
}
