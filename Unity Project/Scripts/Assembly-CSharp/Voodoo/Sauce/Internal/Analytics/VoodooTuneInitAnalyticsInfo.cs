namespace Voodoo.Sauce.Internal.Analytics
{
	public class VoodooTuneInitAnalyticsInfo
	{
		public long HttpResponseCode;

		public double DurationInMilliseconds;

		public bool HasTimeout;

		public bool HasCache;

		public bool FormatIssue;

		public long? DeserializationTime;

		public int Timeout;

		public ulong PayloadSize;
	}
}
