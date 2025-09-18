using System.Collections.Generic;
using Firebase.Analytics;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class FirebaseAnalyticsEvent : BaseAnalyticsEvent
	{
		private Dictionary<string, object> _properties;

		public string GetEventName()
		{
			return null;
		}

		protected override string GetAnalyticsProviderName()
		{
			return null;
		}

		public FirebaseAnalyticsEvent(string eventName, Dictionary<string, object> properties)
			: base(null)
		{
		}

		protected override void PerformTrackEvent()
		{
		}

		private void UpdateEventNameToFirebaseSpecific()
		{
		}

		private void UpdateParamKeysToFirebaseSpecific()
		{
		}

		private List<Parameter> ToParameters()
		{
			return null;
		}

		private static string GetFirebaseKey(string key)
		{
			return null;
		}
	}
}
