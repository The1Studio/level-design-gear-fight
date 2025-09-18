using System.Collections.Generic;

namespace Voodoo.Sauce.Internal.Analytics
{
	internal class ProgressEvent : GameAnalyticsEvent
	{
		private readonly GameAnalyticsBridge.GAProgressionStatus _status;

		private readonly string _progress;

		private readonly int? _score;

		private readonly Dictionary<string, object> _customFields;

		protected override void PerformTrackEvent()
		{
		}

		public ProgressEvent(GameAnalyticsBridge.GAProgressionStatus status, string progress, int? score, Dictionary<string, object> customFields)
			: base(null)
		{
		}
	}
}
