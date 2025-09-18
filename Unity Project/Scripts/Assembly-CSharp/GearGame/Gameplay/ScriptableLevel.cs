using System;
using GearGame.Control;
using Sirenix.OdinInspector;
using UnityEngine;

namespace GearGame.Gameplay
{
	[CreateAssetMenu(menuName = "Gameplay/Level")]
	public class ScriptableLevel : SerializedScriptableObject
	{
		[Serializable]
		public class ItemCollection
		{
			[field: SerializeField]
			public ScriptableGear[] AllItems { get; private set; }
		}

		[SerializeField]
		private FightGenerator.FightDetail[] allFights;

		[SerializeField]
		private ScriptableTroop[] allStructures;

		[SerializeField]
		private int numLevels;

		[SerializeField]
		private bool useLevelValueForNIV;

		[SerializeField]
		private bool useCustomLevelForPayouts;

		[SerializeField]
		private int customLevelForPayouts;

		[SerializeField]
		private ItemCollection[] allGearStoreCollections;

		[SerializeField]
		private ItemCollection[] allPremiumGearStoreCollections;

		[SerializeField]
		private bool overrideTargetLevelForMax;

		[SerializeField]
		private int targetLevelMaxForNIV;

		[SerializeField]
		private double levelNIVMax;

		[SerializeField]
		private double levelNIVMin;

		[SerializeField]
		private int targetLevelForNIV;

		[SerializeField]
		private ScriptableDifficultyProfile difficultyProfile;

		[field: SerializeField]
		public bool DoUseCustomFights { get; private set; }

		[field: SerializeField]
		public bool DoUseCustomGears { get; private set; }

		[field: SerializeField]
		public string ID { get; private set; }

		[field: SerializeField]
		public ABTestingPuzzlesConfig.PuzzleConfigs PuzzleConfiguration { get; private set; }

		[field: SerializeField]
		public ScriptableGridData CustomLevelGrid { get; private set; }

		[field: SerializeField]
		public int StartingCoins { get; private set; }

		[field: SerializeField]
		public int NumberOfSpinners { get; private set; }

		[field: SerializeField]
		public string TutorialSkipString { get; private set; }

		public static float GetFailPercent(float percent01)
		{
			return 0f;
		}

		public ScriptableGear[] GetRegularStoreCollection(int level, int tier)
		{
			return null;
		}

		public ScriptableGear[] GetPremiumStoreCollection(int level, int tier)
		{
			return null;
		}

		public FightGenerator.FightDetail[] GetAllFights(out Tuple<double, double> difficultyDetail)
		{
			difficultyDetail = null;
			return null;
		}

		public Tuple<double, double> GetFightPayout()
		{
			return null;
		}

		public Tuple<double, double> GetFightPayout(int levelOn)
		{
			return null;
		}
	}
}
