using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Preserve]
	internal class AdjustAnalyticsProvider : BaseAnalyticsProviderWithLogger, IAnalyticsAttributionProvider
	{
		private static AdjustParameters _parameters;

		internal override VoodooSauce.AnalyticsProvider GetProviderEnum()
		{
			return default(VoodooSauce.AnalyticsProvider);
		}

		public AdjustAnalyticsProvider()
		{
		}

		internal AdjustAnalyticsProvider(AdjustParameters parameters)
		{
		}

		public override void Instantiate(string mediation)
		{
		}

		public override void Initialize(AnalyticsProviderInfo info)
		{
		}

		public AttributionData GetAttributionData()
		{
			return null;
		}

		private static void RegisterEvents()
		{
		}

		private static void OnGameFinished(GameFinishedParameters parameters)
		{
		}

		private static void OnImpressionTracked(ImpressionAnalyticsInfo impressionInfo)
		{
		}

		private static void TrackConversionEvent(ConversionEventInfo conversionEventInfo)
		{
		}

		private static void TrackCustomEvent(string eventName, Dictionary<string, object> customVariables, string eventType, List<VoodooSauce.AnalyticsProvider> analyticsProviders, Dictionary<string, object> contextVariables = null)
		{
		}

		private static void OnImpressionAudioAdEvent(AudioAdImpressionAnalyticsInfo impressionInfo)
		{
		}

		private static bool IsTestMode()
		{
			return false;
		}
	}
}
