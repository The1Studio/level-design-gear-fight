namespace Voodoo.Sauce.Internal.Analytics
{
	public class AudioAdAnalyticsInfo
	{
		public string networkName;

		public string impressionId;

		public int adCount;

		public int gameCount;

		public string audioAdType;

		public static T Create<T>() where T : AudioAdAnalyticsInfo, new()
		{
			return null;
		}

		public T Copy<T>() where T : AudioAdAnalyticsInfo, new()
		{
			return null;
		}
	}
}
