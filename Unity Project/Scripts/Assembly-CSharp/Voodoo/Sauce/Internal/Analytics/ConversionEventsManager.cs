using System;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class ConversionEventsManager
	{
		private DateTime? _expirationDateTime;

		private ConversionEventsSettings _eventsSettings;

		private static ConversionEventsManager instance;

		internal static ConversionEventsManager Instance => null;

		internal void Initialize(ConversionEventsSettings settings)
		{
		}

		internal void Initialize(ConversionEventsSettings eventsSettings, DateTime? installDate)
		{
		}

		internal ConversionEventInfo GetInterstitialConversionEvent(AdClosedEventAnalyticsInfo adEvent)
		{
			return null;
		}

		internal ConversionEventInfo GetRewardedVideoConversionEvent(AdClosedEventAnalyticsInfo adEvent)
		{
			return null;
		}

		private ConversionEventInfo GetConversionAdEvent(AdClosedEventAnalyticsInfo adEvent, ConversionEventName conversionEventName)
		{
			return null;
		}

		private bool IsEventsNotExpired()
		{
			return false;
		}
	}
}
