using JetBrains.Annotations;

namespace Voodoo.Sauce.Internal.Analytics
{
	public static class VoodooAnalyticsConfig
	{
		public static bool isLocalTimestampEnabled;

		[CanBeNull]
		public static AnalyticsConfig AnalyticsConfig { get; set; }
	}
}
