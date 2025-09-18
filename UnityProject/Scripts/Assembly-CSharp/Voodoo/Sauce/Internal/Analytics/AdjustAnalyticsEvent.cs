using System.Collections.Generic;
using JetBrains.Annotations;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class AdjustAnalyticsEvent : BaseAnalyticsEvent
	{
		[CanBeNull]
		private Dictionary<string, object> _parameter;

		protected override string GetAnalyticsProviderName()
		{
			return null;
		}

		public AdjustAnalyticsEvent(string eventName, [CanBeNull] Dictionary<string, object> parameter)
			: base(null)
		{
		}

		protected override void PerformTrackEvent()
		{
		}
	}
}
