using Voodoo.Sauce.Internal.DebugScreen.CodeStage.AdvancedFPSCounter;

namespace Voodoo.Sauce.Tools.PerformanceDisplay
{
	public static class PerformanceDisplayManager
	{
		private static bool _isEnabled;

		private static AFPSCounter _prefab;

		private const string SHOW_PERFORMANCE_DISPLAY_KEY = "Voodoo_PerformanceDisplayEnabled";

		public static bool IsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static void Initialize(AFPSCounter prefab)
		{
		}

		private static void InitializeInternal()
		{
		}

		private static void SetEnabled(bool setEnabled)
		{
		}
	}
}
