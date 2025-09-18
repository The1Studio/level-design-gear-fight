using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GearGame.Control
{
	public abstract class ScriptableUnlockableUpgradable : ScriptableObject
	{
		public static readonly int[] StarValues;

		[field: SerializeField]
		public string ID { get; private set; }

		[field: SerializeField]
		public bool UnlockedByDefault { get; set; }

		[field: SerializeField]
		public int EvolveLevel { get; private set; }

		[field: SerializeField]
		public int StartingLevel { get; private set; }

		[field: SerializeField]
		public ScriptableUnlockableUpgradable EvolvesInto { get; protected set; }

		public event Action<ScriptableUnlockableUpgradable> OnLevelChanged
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

		public event Action<ScriptableUnlockableUpgradable> OnEvolved
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

		public event Action<ScriptableUnlockableUpgradable> OnUnlocked
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

		public ScriptableUnlockableUpgradable GetCurrentUpgradeAfterEvolution()
		{
			return null;
		}

		public void SetStartingLevel(int level)
		{
		}

		public void ConvertSetStartingLevel()
		{
		}

		public int GetStartingLevel()
		{
			return 0;
		}

		public bool IsUnlocked()
		{
			return false;
		}

		public void Unlock()
		{
		}

		public bool HasEvolved()
		{
			return false;
		}

		public bool IsMaxLevel()
		{
			return false;
		}

		public virtual bool TryEvolveFree()
		{
			return false;
		}

		public bool TryIncrementLevelFree()
		{
			return false;
		}

		public int GetNumberOfUpgrades(bool getCombinedLevelForAllEvolutions = false)
		{
			return 0;
		}

		public int GetNumStars()
		{
			return 0;
		}

		public Tuple<int, int, int> GetEvolutionProgress(bool evolveIfOverLevel = false)
		{
			return null;
		}
	}
}
