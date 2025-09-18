using Voodoo.Nakama.Data;

namespace LaunchOps.NakamaExample
{
	public static class ExampleSaveSystem
	{
		public static LevelSaveData LevelData => null;

		public static CurrenciesSaveData CurrenciesData => null;

		public static int GetCurrentLevel()
		{
			return 0;
		}

		public static void SetCurrentLevel(int index)
		{
		}

		public static int GetCurrentSoft()
		{
			return 0;
		}

		public static void SetCurrentSoft(int value)
		{
		}

		private static T GetFromServer<T>() where T : ServerBaseData
		{
			return null;
		}
	}
}
