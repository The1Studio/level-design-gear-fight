using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Items;
using UnityEngine;

namespace GearGame.Control
{
	[Serializable]
	public class GearUpgradeUnlockProfile
	{
		public struct UpgradeDetails
		{
			public int UnlockCost { get; }

			public int EvolutionCost { get; }

			public UpgradeDetails(int unlockCost, int evolutionCost)
			{
				UnlockCost = 0;
				EvolutionCost = 0;
			}
		}

		public enum Tier
		{
			C = 0,
			B = 1,
			A = 2,
			S = 3,
			SPlus = 4,
			FORCED = 99
		}

		[Flags]
		public enum UnlockRestrictions
		{
			None = 0,
			MinLevelRequired = 2,
			IAPOnly = 4,
			Reward = 8
		}

		[SerializeField]
		private Tier baseTier;

		[ReadOnly]
		[SerializeField]
		private ScriptableGear attachedGear;

		[SerializeField]
		private UnlockRestrictions allUnlockRestrictions;

		[SerializeField]
		private int minLevelGettingGears;

		[SerializeField]
		private string lockedDescriptionLocalizationString;

		public static Dictionary<Tier, UpgradeDetails> AllUpgradeDetails => null;

		public UnlockRestrictions AllUnlockRestrictions => default(UnlockRestrictions);

		public Tier BaseTier => default(Tier);

		public bool ShowMinLevel => false;

		public bool ShowLockedDescriptionString => false;

		public string LockedDescriptionLocalizationString => null;

		public event Action<ScriptableGear, int> OnGearNumberChanged
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

		public event Action<ScriptableGear, Tier> OnGearEvolutionChanged
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

		public int GetCurrentNumberGears()
		{
			return 0;
		}

		public int GetTotalNumberGears()
		{
			return 0;
		}

		public int GetStartingLevel()
		{
			return 0;
		}

		public int GetLastDisplayedPowerLevel()
		{
			return 0;
		}

		public int GetNumberEvolutions()
		{
			return 0;
		}

		public UpgradeDetails GetCurrentUpgradeDetails()
		{
			return default(UpgradeDetails);
		}

		public Tier GetCurrentTier(bool checkIfPendingEvolutionWouldMakeUsMaxTier = false)
		{
			return default(Tier);
		}

		public bool CanMiniGearBeDropped(bool forIAP)
		{
			return false;
		}

		public void SetGear(ScriptableGear attachedGear)
		{
		}

		public void IncrementGears(TransactionLocation location, int amount = 1)
		{
		}

		public bool TryEvolve()
		{
			return false;
		}

		public void Evolve()
		{
		}

		public void SetStartingLevel(int level)
		{
		}

		public bool TryUnlock()
		{
			return false;
		}

		public bool IsPendingUnlock()
		{
			return false;
		}

		public bool IsPendingEvolution()
		{
			return false;
		}

		public bool IsMaxTier(bool checkIfPendingEvolutionWouldMakeUsMaxTier)
		{
			return false;
		}
	}
}
