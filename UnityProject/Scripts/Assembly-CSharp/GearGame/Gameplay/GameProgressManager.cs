using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using GearGame.Control;
using GearGame.Gameplay.Managers;
using Items;
using ScriptableTemplates;
using UnityEngine;
using Voodoo.Sauce.Core;

namespace GearGame.Gameplay
{
	public class GameProgressManager : MonoBehaviour, IGameplaySaveLoad
	{
		private static GameProgressManager instance;

		[SerializeField]
		private float offsetPerFight;

		[SerializeField]
		private float moveDuration;

		[SerializeField]
		private Transform cameraTracking;

		private List<object> allTransitionBlockers;

		private List<object> allStoreBlockers;

		private FightGenerator.FightDetail[] allFights;

		private FightGenerator.FightDetail currentFight;

		private int fightIndex;

		private int structuresSpawnedSoFar;

		private int nextStructureIndex;

		private bool hasInitialized;

		private Action _setToStoreDelegate;

		private Action _winFightDelegate;

		public static GameProgressManager Instance => null;

		public FightGenerator.FightDetail CurrentFight => null;

		public int TotalLevels => 0;

		public ChapterSettings CurrentChapterData => null;

		public int CurrentChapterIndex => 0;

		public int FightIndex => 0;

		public int NextStructureIndex => 0;

		public int[] AllStructureIndices { get; private set; }

		public bool IsMaxLevel { get; private set; }

		public FightGenerator.FightDetail[] AllFights => null;

		public ScriptableLevel LevelOn { get; private set; }

		public double NIVMaxForLevel { get; private set; }

		public double NIVMinForLevel { get; private set; }

		public EnemyStructureController SpawnedStructure { get; private set; }

		public string ID => null;

		public event Action<int> FightIndexChanged
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

		private void CreateSingleton()
		{
		}

		private void Awake()
		{
		}

		public void SetLevel()
		{
		}

		private void Start()
		{
		}

		public void Init(Action setToStoreDelegate, Action winFightDelegate)
		{
		}

		private void OnDestroy()
		{
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		private ChapterSettings GetCurrentChapterData()
		{
			return null;
		}

		private int GetTotalLevels()
		{
			return 0;
		}

		private int GetCurrentChapterIndex()
		{
			return 0;
		}

		public void AddTransitionBlocker(object o)
		{
		}

		public void RemoveTransitionBlocker(object o)
		{
		}

		public void AddStoreBlocker(object o)
		{
		}

		public void RemoveStoreBlocker(object o)
		{
		}

		private void OnVoodooSauceInit(VoodooSauceInitCallbackResult _)
		{
		}

		public void Initialize()
		{
		}

		private void GenerateFights()
		{
		}

		public void ProgressForward(float delay)
		{
		}

		public void ClearStructure()
		{
		}

		public void HealOrRespawnStructure()
		{
		}

		private void TrySpawnStructure(bool doOffset)
		{
		}

		public static void AddCurrencyEvent(ItemNames currency, double value, TransactionLocation location)
		{
		}

		public void SetSaveData(IGameplaySaveLoad.SaveData data)
		{
		}

		IGameplaySaveLoad.SaveChunk[] IGameplaySaveLoad.GetSaveData()
		{
			return null;
		}
	}
}
