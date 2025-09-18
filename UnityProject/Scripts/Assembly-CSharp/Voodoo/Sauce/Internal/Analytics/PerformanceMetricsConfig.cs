using System;

namespace Voodoo.Sauce.Internal.Analytics
{
	[Serializable]
	public class PerformanceMetricsConfig
	{
		public bool active;

		public float period;

		public bool enableThermalState;
	}
}
