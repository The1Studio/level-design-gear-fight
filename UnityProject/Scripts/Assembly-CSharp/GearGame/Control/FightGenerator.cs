using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace GearGame.Control
{
	public class FightGenerator : MonoBehaviour
	{
		[Serializable]
		public class FightDetail
		{
			[Serializable]
			public class EnemyDetail
			{
				[field: SerializeField]
				public ScriptableTroop Character { get; private set; }

				[field: SerializeField]
				public int Level { get; set; }

				[field: SerializeField]
				public float Delay { get; private set; }

				[field: SerializeField]
				public bool IsBeast { get; set; }

				public event Action<EnemyDetail> OnCompleted
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

				public EnemyDetail(ScriptableTroop character, float delay, int level, bool isBeast)
				{
				}
			}

			[Serializable]
			private class TupleWrapper
			{
				[field: SerializeField]
				public float Proportion { get; private set; }

				[field: SerializeField]
				public ScriptableTroop Character { get; private set; }
			}

			private int numberKilled;

			[SerializeField]
			private bool overrideStructureLevel;

			[SerializeField]
			private int structureLevelOverride;

			public bool HasStructure => false;

			public bool OverrideStructureLevel => false;

			public int StructureLevelOverride => 0;

			[field: SerializeField]
			public List<EnemyDetail> Enemies { get; private set; }

			[field: SerializeField]
			public ScriptableTroop Structure { get; set; }

			[field: SerializeField]
			public int ValueOfFight { get; private set; }

			[field: SerializeField]
			public bool ForceBasicShop { get; private set; }

			[field: SerializeField]
			public int FightOffset { get; set; }

			[field: SerializeField]
			public bool HasStructureChest { get; set; }

			public int NumberKilled
			{
				get
				{
					return 0;
				}
				set
				{
				}
			}

			public int FightLevel { get; set; }

			public double FightNIVTarget { get; set; }

			public event Action<int> OnNumberKilledChanged
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

			public FightDetail(int valueOfFight)
			{
			}

			public void AddNumberOfTroops(double multipier)
			{
			}

			public void ScaleBruteDensity(double multipier)
			{
			}
		}

		private static FightGenerator instance;

		[SerializeField]
		private GameObject[] allBasicTroops;

		[SerializeField]
		private GameObject[] allStartingProducers;

		[SerializeField]
		private ScriptableTroop[] allGrunts;

		[SerializeField]
		private ScriptableTroop[] allRangers;

		[SerializeField]
		private ScriptableTroop[] allBrutes;

		public static FightGenerator Instance => null;

		protected void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		public FightDetail GenerateFight(double nivTarget, int fightLevel, float levelPercent, ScriptableDifficultyProfile difficultyProfile, int fightPayout, int fightIndex, int seed, ScriptableTroop structure)
		{
			return null;
		}
	}
}
