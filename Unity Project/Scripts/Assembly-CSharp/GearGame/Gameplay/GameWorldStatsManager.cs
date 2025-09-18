using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Event;
using GearGame.Control;
using GearGame.Gameplay.Managers;
using Items;
using StatSystem;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class GameWorldStatsManager : MonoBehaviour, IGameplaySaveLoad
	{
		private static GameWorldStatsManager instance;

		public StatFormatSO StatFormatSetting;

		private NotificationEventData notificationData;

		[SerializeField]
		private ScriptableSkill healthSkill;

		[SerializeField]
		private ScriptableSkill[] allSkillsToTrack;

		private GameStateManager.GameState _previousState;

		private double totalDamageAgainstEnemies;

		private float totalTimer;

		private int lastCheckedHealth;

		private int coins;

		private int currentHealth;

		private int maxHealth;

		private int totalAlliedTroopSpawns;

		private float fightStartTime;

		private float fightEndTime;

		private bool hasInitializedHealth;

		private readonly List<float> allDelaysBeforeAttack;

		private Action _onLoseCallback;

		public static GameWorldStatsManager Instance => null;

		public int DamageLastTurn { get; private set; }

		public int Coins
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public int BaseHealth => 0;

		public int CurrentHealth
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public int MaxHealth
		{
			get
			{
				return 0;
			}
			private set
			{
			}
		}

		public string ID => null;

		public event Action<float> OnCoinsChanged
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

		public event Action<int> OnHealthChanged
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

		public event Action<Vector2> OnCoinCollected
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

		public event Action<Vector2, int> OnCoinsCollected
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

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Init(Action onLoseCallback)
		{
		}

		private void OnDestroy()
		{
		}

		private void AllySpawned(TroopController character)
		{
		}

		public float GetAverageDelayBeforeAttack()
		{
			return 0f;
		}

		public float GetTotalTroopsSpawned()
		{
			return 0f;
		}

		public void AddDelayBeforeAttack(float delay)
		{
		}

		public double GetDamagePerSecond()
		{
			return 0.0;
		}

		private void EnemySpawned(TroopController character)
		{
		}

		private void EnemyHealthChanged(TroopHealthController controller, double hp)
		{
		}

		public void AddSkillsToDictionary(ref Dictionary<string, object> referenceDict)
		{
		}

		public float GetFightDuration()
		{
			return 0f;
		}

		private void StateChanged(GameStateManager.GameState state)
		{
		}

		private void HealthValueChanged(double value)
		{
		}

		public bool TrySpendCoins(int positiveAmount)
		{
			return false;
		}

		public void UnlimitedHealth()
		{
		}

		public void Heal(int amount)
		{
		}

		public void TakeDamage(int amount = 1)
		{
		}

		public void CollectCoins(Vector2 screenPosition, int amount)
		{
		}

		public void CollectExtraCoins(Vector2 screenPosition, int amount, ItemNames item)
		{
		}

		public void CollectCoin(Vector3 worldPosition)
		{
		}

		public void IncrementCoins(int value)
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
