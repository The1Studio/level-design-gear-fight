using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal abstract class BaseAnalyticsEvent
	{
		protected string EventName { get; set; }

		protected string EventId { get; }

		[CanBeNull]
		protected Dictionary<string, object> EventData { get; set; }

		protected abstract void PerformTrackEvent();

		protected abstract string GetAnalyticsProviderName();

		protected BaseAnalyticsEvent(string eventName, [CanBeNull] Dictionary<string, object> eventData = null)
		{
		}

		internal void Track()
		{
		}

		private void LogEventInDebugger()
		{
		}

		private void LogEventExceptionInDebugger(Exception e)
		{
		}
	}
}
