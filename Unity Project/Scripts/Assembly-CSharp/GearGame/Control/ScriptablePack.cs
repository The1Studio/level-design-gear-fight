using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GearGame.Gameplay.UI;
using GearGame.UI;
using UnityEngine;

namespace GearGame.Control
{
	[CreateAssetMenu(menuName = "Gameplay/Pack")]
	public class ScriptablePack : ScriptableObject
	{
		[Serializable]
		public class PackUnlock
		{
			[field: SerializeField]
			public ScriptableGear Gear { get; private set; }

			[field: SerializeField]
			public string UnlockGUID { get; set; }
		}

		public enum UnlockDetail
		{
			Cost = 0,
			Level = 1
		}

		public readonly int[] RequiredXP;

		[SerializeField]
		private UnlockDetail theseUnlockDetails;

		[SerializeField]
		private int unlockCost;

		[SerializeField]
		private int unlockLevel;

		[SerializeField]
		private ScriptableGear[] allGeneralGears;

		public UnlockDetail TheseUnlockDetails => default(UnlockDetail);

		public int UnlockCost => 0;

		public int UnlockLevel => 0;

		[field: SerializeField]
		public string ID { get; private set; }

		[field: SerializeField]
		public string DisplayNameLocalizationKey { get; private set; }

		[field: SerializeField]
		public string DisplayNameLocalizationFullKey { get; private set; }

		[field: SerializeField]
		public Sprite PackDisplaySprite { get; private set; }

		[field: SerializeField]
		public Sprite PackIcon { get; private set; }

		[field: SerializeField]
		public ScriptableTroop GruntTroop { get; private set; }

		[field: SerializeField]
		public ScriptableTroop RangedTroop { get; private set; }

		[field: SerializeField]
		public ScriptableTroop BruteTroop { get; private set; }

		[field: SerializeField]
		public UpgradeableTroopUIController GruntTroopUIController { get; private set; }

		[field: SerializeField]
		public UpgradeableTroopUIController RangedTroopUIController { get; private set; }

		[field: SerializeField]
		public UpgradeableTroopUIController BruteTroopUIController { get; private set; }

		[field: SerializeField]
		public bool UnlockedByDefault { get; private set; }

		[field: SerializeField]
		public PackUnlock[] AllPackUnlocks { get; private set; }

		[field: SerializeField]
		public PackUnlockedPopup AssociatedPopup { get; private set; }

		public event Action<ScriptablePack, int> OnLevelChanged
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

		public event Action<ScriptablePack, int> OnXPChanged
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

		public event Action<ScriptablePack> OnUnlocked
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

		public HashSet<ScriptableTroop> GetCharacters()
		{
			return null;
		}

		public void CheckForAllGears()
		{
		}

		public ScriptableGear[] GetAllGears(bool unlockedOnly, bool includeBaseTroops = false)
		{
			return null;
		}

		public ScriptableGear[] GetAllPackGears(bool unlockedOnly)
		{
			return null;
		}

		public bool IsMaxLevel()
		{
			return false;
		}

		public void Unlock()
		{
		}

		private void SetStartingLevel(ScriptableTroop character, int level)
		{
		}

		public void CatchUp()
		{
		}

		public bool IsUnlocked()
		{
			return false;
		}

		public float GetXPDisplay()
		{
			return 0f;
		}

		public int GetXP()
		{
			return 0;
		}

		public int GetPendingXP()
		{
			return 0;
		}

		public void ClearPendingXP()
		{
		}

		public void IncrementPendingXP(int amount)
		{
		}

		public void IncrementXP(int amount)
		{
		}

		public int GetRequiredXP()
		{
			return 0;
		}

		public bool IsPendingLevelUp()
		{
			return false;
		}

		public bool TryLevelUp(out PackUnlock packUnlock)
		{
			packUnlock = null;
			return false;
		}

		public void IncrementLevel()
		{
		}

		public double GetNetInvestmentValue(bool areGruntsFree)
		{
			return 0.0;
		}

		public int GetLevel()
		{
			return 0;
		}

		public PackUnlock GetUnlock()
		{
			return null;
		}
	}
}
