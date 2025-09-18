using System.Collections.Generic;

namespace Voodoo.Sauce.Privacy
{
	public static class PrivacyEventsManager
	{
		private enum ScreenName
		{
			learn_more_popup = 0,
			apple_popup = 1,
			gdpr_popup = 2
		}

		private enum EventName
		{
			screen_view = 0,
			button_click = 1,
			tcf_consents = 2
		}

		private enum Property
		{
			screen_name = 0,
			button = 1,
			toggle_ads = 2,
			toggle_analytics = 3
		}

		public enum ApplePopupButton
		{
			allow = 0,
			deny = 1
		}

		public enum GDPRPopupButton
		{
			proceed = 0,
			more_info = 1,
			more_info_sdk = 2,
			more_info_ads = 3,
			more_info_analytics = 4,
			more_info_age_limit = 5
		}

		private static string EventType;

		private static List<VoodooSauce.AnalyticsProvider> analyticsProviders;

		public static void OnLearnMoreDisplay()
		{
		}

		public static void OnLearnMoreClick()
		{
		}

		public static void OnAppleIdfaAuthorizationDisplay()
		{
		}

		public static void OnAppleIdfaAuthorizationClick(ApplePopupButton applePopupButton)
		{
		}

		public static void OnGDPRDisplay()
		{
		}

		public static void OnGDPRProceedClick(bool ads, bool analytics)
		{
		}

		public static void OnGDPRClick(GDPRPopupButton GDPRPopupButton)
		{
		}

		public static void OnConsentUpdate(Dictionary<string, object> consentDictionary)
		{
		}
	}
}
