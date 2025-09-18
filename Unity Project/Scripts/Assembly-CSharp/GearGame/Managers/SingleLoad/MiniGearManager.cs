using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GearGame.Control;
using GearGame.Gameplay.Misc;
using GearGame.SingleLoad;
using GearGame.UI;
using Items;
using UnityEngine;

namespace GearGame.Managers.SingleLoad
{
	public class MiniGearManager : MonoBehaviour
	{
		private static MiniGearManager instance;

		public static readonly Dictionary<GearUpgradeUnlockProfile.Tier, float> TierDropChance;

		[SerializeField]
		private MiniGearCanvasController miniGearCanvas;

		[SerializeField]
		private ScriptableGear[] allForcedGears;

		[SerializeField]
		private int[] numDropsPerTenLevels;

		[SerializeField]
		private float evenessOfMiniGearSpreadPerTenLevels;

		[SerializeField]
		private float evenessOfMiniGearSpreadPerFight;

		private int[] levelDrops;

		private int[] levelDropsLooped;

		public static MiniGearManager Instance => null;

		[field: SerializeField]
		public Sprite MiniGearDisplaySprite { get; private set; }

		public event Action<ScriptableGear> OnMiniGearCollected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void GearNumberChanged(ScriptableGear gear, int arg2)
		{
		}

		public void TryRemovePendingGear(ScriptableGear gear)
		{
		}

		public void TryDropPendingGears(Transform t, Vector3 position)
		{
		}

		private void ItemUnlocked(WorldMetaLockManager.UnlockDetail detail)
		{
		}

		private void GetOrGenerateLevelDrops()
		{
		}

		private Tuple<int[], int[]> GenerateMiniGearLevelDrops()
		{
			return null;
		}

		public ScriptableGear[] GetMiniGearsForLevel(int level)
		{
			return null;
		}

		public int[] GenerateMiniGearDropsForFights(int totalNumberGears, int totalNumberFights)
		{
			return null;
		}

		private int GetNumRemainingForForcedGear(ScriptableGear gear)
		{
			return 0;
		}

		private GearUpgradeUnlockProfile.Tier[] GenerateClaimSet(int atLeast)
		{
			return null;
		}

		private GearUpgradeUnlockProfile.Tier[] GetClaimSet(int number)
		{
			return null;
		}

		public void DebugIncrementMiniGearClaimSetOn()
		{
		}

		public ScriptableGear[] GenerateMiniGears(bool forIAP, int number)
		{
			return null;
		}

		public CollectableMiniGear GenerateCollectableMiniGear(Transform parent, Vector3 position, ScriptableGear gear, bool jumpRandom, TransactionLocation location)
		{
			return null;
		}

		public void CollectWorldMiniGear(CollectableMiniGear miniGear, TransactionLocation location)
		{
		}

		public void GenerateUIMiniGear(Vector3 screenPosition, MiniGearCanvasController.CollectionType type, ScriptableGear[] gears, TransactionLocation location)
		{
		}

		public void GenerateRandomUIMiniGears(Vector3 screenPosition, MiniGearCanvasController.CollectionType type, TransactionLocation location, int number)
		{
		}
	}
}
