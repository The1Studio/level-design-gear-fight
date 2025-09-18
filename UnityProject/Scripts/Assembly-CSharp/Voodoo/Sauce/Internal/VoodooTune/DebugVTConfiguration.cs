using System.Collections.Generic;
using Voodoo.Tune.Core;

namespace Voodoo.Sauce.Internal.VoodooTune
{
	internal class DebugVTConfiguration
	{
		private const string TAG = "DebugVTConfiguration";

		internal Sandbox SelectedSandbox { get; set; }

		internal List<Segment> SelectedSegments { get; set; }

		internal List<ABTest> SelectedAbTests { get; set; }

		internal List<Cohort> SelectedCohorts { get; set; }

		internal string VersionId { get; set; }

		internal bool IsDefaultConfiguration => false;

		internal bool IsSandbox => false;

		internal bool IsSimulation => false;

		internal bool HasNoneSelected => false;

		internal string SelectedAbTestsToString => null;

		internal string SelectedCohortsToString => null;

		internal string SelectedSegmentsToString => null;

		internal string SelectedABTestsAndCohortsToString => null;

		internal bool IsValid => false;

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		internal void PersistOnPlayerPrefs()
		{
		}

		internal static DebugVTConfiguration GetFromPlayerPrefs()
		{
			return null;
		}
	}
}
