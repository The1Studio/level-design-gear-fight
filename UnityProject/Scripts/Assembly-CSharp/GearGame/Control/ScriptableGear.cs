using System;
using System.Runtime.CompilerServices;
using GearGame.Gameplay;
using Items;
using NaughtyAttributes;
using UnityEngine;

namespace GearGame.Control
{
	[CreateAssetMenu(menuName = "Gameplay/Gear")]
	public class ScriptableGear : ItemSO
	{
		[Serializable]
		public class GearInfo
		{
			[Flags]
			public enum GearTags
			{
				None = 0,
				TroopMelee = 0x40,
				TroopRanged = 0x20,
				TroopElite = 0x200,
				SingleTarget = 2,
				MultiTarget = 0x80,
				AreaOfEffect = 4,
				DamageOverTime = 8,
				Buff = 0x10,
				Income = 0x1000,
				Projectile = 0x400,
				ProductionAdderGear = 0x800,
				Boost = 0x2000,
				Special = 0x100
			}

			[SerializeField]
			private string _displayNameLocKey;

			[SerializeField]
			private string _displayDescriptionLocKey;

			[SerializeField]
			private GearTags allGearTags;

			public GearTags AllGearTags => default(GearTags);

			public string GetFinalDescriptionString(ScriptableGear gear)
			{
				return null;
			}

			public string GetFinalTitleString(ScriptableGear gear)
			{
				return null;
			}

			private string GetFinalDisplayString(ScriptableGear gear, string s)
			{
				return null;
			}
		}

		public enum GearType
		{
			Producer = 0,
			Spell = 1,
			Boost = 2,
			Troop = 3
		}

		public enum UnlockType
		{
			None = 0,
			CustomGears = 1,
			Special = 2
		}

		public enum SpawningType
		{
			None = 0,
			Regular = 1,
			Premium = 2,
			Both = 3
		}

		public enum SpawningTier
		{
			Starter = -1,
			Tier1 = 0,
			Tier2 = 1,
			Tier3 = 2,
			Tier4 = 3
		}

		[SerializeField]
		private GearUpgradeUnlockProfile upgradeProfile;

		[SerializeField]
		private GameObject miniGearPrefab;

		[SerializeField]
		private GearController gearController;

		[SerializeField]
		private GearInfo gearInfo;

		[SerializeField]
		[Dropdown("GetGoalEntityTypeList")]
		private string goalEntityType;

		public GearUpgradeUnlockProfile UpgradeProfile => null;

		public GameObject MiniGearPrefab => null;

		[field: SerializeField]
		public bool UnlockedByDefault { get; set; }

		[field: SerializeField]
		public bool ShowInPackDisplay { get; set; }

		[field: SerializeField]
		public string ID { get; private set; }

		[field: SerializeField]
		public UnlockType ThisUnlockType { get; private set; }

		public GearType ThisGearType => default(GearType);

		public SpawningTier SpawningTierRegular => default(SpawningTier);

		public SpawningTier SpawningTierPremium => default(SpawningTier);

		public SpawningType ThisSpawningType => default(SpawningType);

		public int InGameCost => 0;

		public ScriptableTroop AssociatedCharacter => null;

		public int GoalEntityType => 0;

		public event Action<ScriptableGear> OnUnlocked
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

		public event Action<ScriptableGear, bool> OnNotificationChanged
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

		public bool CanDropMiniGear(bool forIAP)
		{
			return false;
		}

		public void TriggerHasBeenShown()
		{
		}

		public bool GetHasBeenShown()
		{
			return false;
		}

		public bool HasNotification()
		{
			return false;
		}

		public void ClearNotification()
		{
		}

		public void SetNotification()
		{
		}

		public GearInfo GetGearInfo()
		{
			return null;
		}

		public void IncrementRVEngagement()
		{
		}

		public bool IsUnlocked()
		{
			return false;
		}

		public void Unlock()
		{
		}

		public Sprite GetGearBackgroundSprite()
		{
			return null;
		}

		public Material GetGearSpriteMaterial()
		{
			return null;
		}

		public bool TryGetGearForegroundSprite(out Sprite s)
		{
			s = null;
			return false;
		}

		public string GetGearProductionDisplayString()
		{
			return null;
		}

		public bool DoesMatchGearPrefab(GameObject go)
		{
			return false;
		}

		public GearController InstantiateGear(int overrideLevel = -1)
		{
			return null;
		}

		private static string[] GetGoalEntityTypeList()
		{
			return null;
		}

		public override double GetBalance()
		{
			return 0.0;
		}
	}
}
