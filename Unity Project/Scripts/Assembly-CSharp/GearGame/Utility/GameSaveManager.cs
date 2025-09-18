using IapOffers;
using Items;
using SaveSystem.SaveData;

namespace GearGame.Utility
{
	public static class GameSaveManager
	{
		private static ES3Settings settings;

		public static RVValues RVValues;

		public static PendingIAPs PendingIAPs;

		public static CharacterData CharacterData;

		public static ScriptableLevelData ScriptableLevelData;

		public static GameParams GameParams => null;

		public static TutorialData TutorialData => null;

		public static GameVariables GameVariables => null;

		public static CurrencySave CurrencySave => null;

		public static GearData GearData => null;

		public static PacksSave PacksSave => null;

		public static SkillsSave SkillsSave => null;

		public static UnlockableUpgradables UnlockableUpgradables => null;

		public static BlessingsData BlessingsData => null;

		public static ChapterSave ChapterSave => null;

		public static MetaSave MetaSave => null;

		public static BulkOfferingsSave BulkOfferingsSave => null;

		public static UIUnlockSave UIUnlockSave => null;

		public static MiniBossSave MiniBossSave => null;

		public static TimerSave TimerSave => null;

		public static MigrationData MigrationData => null;

		public static RewardsSave Rewards => null;

		public static IapOfferSave IapOffers => null;

		public static bool HasLoaded { get; private set; }

		private static void Migration350()
		{
		}

		private static void Migration400()
		{
		}

		public static void Migrate()
		{
		}

		public static void Load()
		{
		}

		public static void SaveAllData()
		{
		}

		public static void SaveLocalData()
		{
		}

		private static T Load<T>() where T : new()
		{
			return default(T);
		}

		private static void LoadLocalData()
		{
		}

		public static void OverwriteSaveString(byte[] finalArray)
		{
		}

		public static void TrackEndGame(bool isWin)
		{
		}

		private static void OnWin()
		{
		}
	}
}
