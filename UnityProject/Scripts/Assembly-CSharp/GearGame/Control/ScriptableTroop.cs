using GearGame.Gameplay;
using ScriptableTemplates;
using UnityEngine;

namespace GearGame.Control
{
	[CreateAssetMenu(menuName = "Gameplay/Character")]
	public class ScriptableTroop : ScriptableUnlockableUpgradable
	{
		public enum TroopCategory
		{
			Grunt = 0,
			Ranger = 1,
			Brute = 2,
			Special = 3,
			Elite = 4
		}

		[SerializeField]
		private string _nameLocKey;

		[SerializeField]
		private Vector2Int acceptableLevelRangeForGeneration;

		[SerializeField]
		private ChapterSettings[] onlyIncludedInTheseScenes;

		[SerializeField]
		private bool overrideUnlockCost;

		[SerializeField]
		private int unlockCostOverride;

		[SerializeField]
		private FallingTroopController fallingTroop;

		[SerializeField]
		private TroopController troopController;

		[field: SerializeField]
		public TroopCategory ThisTroopCategory { get; private set; }

		[field: SerializeField]
		public bool IncludedInLevelGeneration { get; private set; }

		public Vector2Int AcceptableLevelRangeForGeneration => default(Vector2Int);

		public ChapterSettings[] OnlyIncludedInTheseScenes => null;

		[field: SerializeField]
		public Sprite DisplaySpriteAlly { get; private set; }

		[field: SerializeField]
		public Sprite DisplaySpriteEnemy { get; private set; }

		[field: SerializeField]
		public Sprite DisplaySpriteGear { get; private set; }

		[field: SerializeField]
		public Sprite DisplaySpriteForUpgradeButton { get; private set; }

		[field: SerializeField]
		public Vector2 AnchoredPositionOffsetForPackDisplay { get; private set; }

		[field: SerializeField]
		public ScriptableGear ScriptableGear { get; set; }

		[field: SerializeField]
		public bool ShowFullScreenPopupWhenUnlocked { get; private set; }

		public override bool TryEvolveFree()
		{
			return false;
		}

		public static double BeautifyValue(double value)
		{
			return 0.0;
		}

		public static double GetStaticDamageForLevel(int level)
		{
			return 0.0;
		}

		public static double GetStaticHealthForLevel(int level)
		{
			return 0.0;
		}

		public static int GetLevelFromNIV(double niv)
		{
			return 0;
		}

		public static double GetStaticCostForLevel(int level)
		{
			return 0.0;
		}

		public bool CanBeIncludedInCurrentScene()
		{
			return false;
		}

		public bool IsInNIVRange(double min, double max)
		{
			return false;
		}

		public double GetInvestment(bool includeUnlockCost = true)
		{
			return 0.0;
		}

		public double GetCurrentDPS()
		{
			return 0.0;
		}

		public double GetCurrentDamage()
		{
			return 0.0;
		}

		public double GetCurrentHealth()
		{
			return 0.0;
		}

		public double GetUnlockCost()
		{
			return 0.0;
		}

		public int GetLevel(bool onlyIfUnlocked)
		{
			return 0;
		}

		public string GetLocalizedName()
		{
			return null;
		}

		public int GetAdjustedLevel()
		{
			return 0;
		}

		public double GetCostForLevel(int level)
		{
			return 0.0;
		}

		public TroopController InstantiateTroop(bool isAlly)
		{
			return null;
		}

		public TroopController InitializeTroop(TroopController troop, bool isAlly, int level = -1, float healthMultiplier = 1f, float damageMultiplier = 1f)
		{
			return null;
		}

		public TroopController InstantiateAndInitializeTroop(bool isAlly, int level = -1, float healthMultiplier = 1f, float damageMultiplier = 1f)
		{
			return null;
		}

		public FallingTroopController InstantiateAndInitializeFallingTroop(bool isAlly, int level = -1, float healthMultiplier = 1f, float damageMultiplier = 1f)
		{
			return null;
		}
	}
}
