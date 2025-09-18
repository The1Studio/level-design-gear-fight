using System.Collections.Generic;
using JetBrains.Annotations;
using Voodoo.Analytics;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class VoodooAnalyticsLoggerEvent : BaseAnalyticsEvent
	{
		private VanEventName? _eventName;

		[CanBeNull]
		private readonly Dictionary<string, object> _data;

		[CanBeNull]
		private readonly string _dataAsString;

		[CanBeNull]
		private readonly string _eventType;

		[CanBeNull]
		private readonly Dictionary<string, object> _customVariables;

		[CanBeNull]
		private readonly Dictionary<string, object> _contextVariables;

		protected override string GetAnalyticsProviderName()
		{
			return null;
		}

		public VoodooAnalyticsLoggerEvent(VanEventName eventName, [CanBeNull] Dictionary<string, object> data, [CanBeNull] string eventType, [CanBeNull] Dictionary<string, object> customVariables, [CanBeNull] Dictionary<string, object> contextVariables)
			: base(null)
		{
		}

		public VoodooAnalyticsLoggerEvent(string eventName, [CanBeNull] Dictionary<string, object> data, [CanBeNull] string eventType, [CanBeNull] Dictionary<string, object> contextVariables)
			: base(null)
		{
		}

		public VoodooAnalyticsLoggerEvent(string eventName, [CanBeNull] string dataAsString, [CanBeNull] string eventType, [CanBeNull] Dictionary<string, object> customVariables, [CanBeNull] Dictionary<string, object> contextVariables)
			: base(null)
		{
		}

		public VoodooAnalyticsLoggerEvent(VanEventName eventName, [CanBeNull] string dataAsString, [CanBeNull] string eventType, [CanBeNull] Dictionary<string, object> customVariables, [CanBeNull] Dictionary<string, object> contextVariables)
			: base(null)
		{
		}

		protected override void PerformTrackEvent()
		{
		}

		private Dictionary<string, object> AddLocalCreatedAt([CanBeNull] Dictionary<string, object> contextVariables)
		{
			return null;
		}
	}
}
