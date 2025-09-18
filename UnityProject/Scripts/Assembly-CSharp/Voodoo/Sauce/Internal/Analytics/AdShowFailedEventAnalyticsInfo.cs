using JetBrains.Annotations;

namespace Voodoo.Sauce.Internal.Analytics
{
	public class AdShowFailedEventAnalyticsInfo : AdEventAnalyticsInfo
	{
		public int AdCount;

		public int AdDuration;

		public int? ErrorCode;

		[CanBeNull]
		public string ErrorMessage;

		public int? AdNetworkErrorCode;

		[CanBeNull]
		public string AdNetworkErrorString;
	}
}
