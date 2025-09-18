namespace Voodoo.Sauce.Internal.Analytics
{
	public class VoodooTuneAbTestAnalyticsInfo
	{
		public readonly string AbTestUuid;

		public readonly string AbTestCohortUuid;

		public readonly string AbTestVersionUuid;

		public VoodooTuneAbTestAnalyticsInfo(string abTestUuid, string abTestCohortUuid, string abTestVersionUuid)
		{
		}

		public VoodooTuneAbTestAnalyticsInfo(string abTestUuid, string abTestCohortUuid)
		{
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private static bool IsSameValue(string oldValue, string newValue)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
