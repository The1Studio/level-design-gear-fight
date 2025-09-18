using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class DesignEvent : GameAnalyticsEvent
	{
		private readonly Dictionary<string, object> _customFields;

		protected override void PerformTrackEvent()
		{
		}

		public DesignEvent(string eventName, Dictionary<string, object> customFields)
			: base(null)
		{
		}
	}
}
