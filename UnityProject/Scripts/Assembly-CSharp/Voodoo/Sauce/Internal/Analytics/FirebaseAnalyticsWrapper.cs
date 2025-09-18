using System;
using System.Collections.Generic;
using Voodoo.Sauce.Privacy;

namespace Voodoo.Sauce.Internal.Analytics
{
	public static class FirebaseAnalyticsWrapper
	{
		private const string TAG = "FirebaseAnalyticsWrapper";

		private static bool _isFirebaseInitialized;

		private static bool _isEnabled;

		private static readonly Queue<FirebaseAnalyticsEvent> EventsQueue;

		internal static void SubscribeToFirebaseInitialization(PrivacyCore.GdprConsent consent, Action<bool> callback)
		{
		}

		internal static void TrackEvent(string eventName, Dictionary<string, object> properties = null)
		{
		}

		internal static void TrackPurchase(IIAPCommonInfo purchaseInfo)
		{
		}

		private static void SetAnalyticsCollection(bool consent)
		{
		}
	}
}
