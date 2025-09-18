namespace Voodoo.Sauce.Internal.CrossPromo.Mercury
{
	public class MercuryTestModeManager
	{
		private enum TestModeState
		{
			Unknown = 0,
			Enabled = 1,
			Disabled = 2
		}

		private const string MERCURY_TEST_MODE_PREFS_KEY = "MercuryApiTestModeKey";

		private static MercuryTestModeManager _instance;

		private TestModeState _testModeState;

		public static MercuryTestModeManager Instance => null;

		public void Initialize()
		{
		}

		public bool IsTestModeEnabled()
		{
			return false;
		}

		public void SetTestMode(bool enabled)
		{
		}
	}
}
