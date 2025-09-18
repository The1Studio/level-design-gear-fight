namespace Voodoo.Sauce.Internal.Analytics
{
	public struct PerformanceMetricsAnalyticsInfo
	{
		public float BatteryLevel;

		public int Volume;

		public double AverageMemoryUsagePercentage;

		public FloatMetric Fps;

		public FloatMetric MemoryUsage;

		public int BadFrames;

		public int TerribleFrames;

		public int ThermalState;

		public string GetBatteryLevelAsString()
		{
			return null;
		}
	}
}
