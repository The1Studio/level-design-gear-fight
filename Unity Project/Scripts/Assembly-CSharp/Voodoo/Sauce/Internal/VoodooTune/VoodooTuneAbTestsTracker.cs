using System;
using System.Collections.Generic;
using Voodoo.Sauce.Internal.Analytics;
using Voodoo.Tune.Core;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	internal class VoodooTuneAbTestsTracker
	{
		private const string TAG = "VoodooTuneAbTestsTracker";

		private readonly List<string> _abTests;

		private readonly List<string> _cohorts;

		private readonly List<string> _treatments;

		private readonly string _version;

		internal VoodooTuneAbTestsTracker()
		{
		}

		public void TrackAbTestModifications(Voodoo.Tune.Core.VoodooConfig config)
		{
		}

		private void TrackAbTestModifications(List<string> abTestUuids, List<string> abTestCohortUuids, string abTestVersionUuid)
		{
		}

		internal static Tuple<List<VoodooTuneAbTestAnalyticsInfo>, List<VoodooTuneAbTestAnalyticsInfo>> GetAssignmentsAndExits(List<string> oldAbTestUuids, List<string> oldAbTestCohortUuids, List<string> abTestUuids, List<string> abTestCohortUuids, string oldAbTestVersionUuid, string abTestVersionUuid)
		{
			return null;
		}

		private static List<VoodooTuneAbTestAnalyticsInfo> GetAbTestsAnalyticsInfo(IReadOnlyList<string> abTests, IReadOnlyList<string> cohorts, string version)
		{
			return null;
		}
	}
}
