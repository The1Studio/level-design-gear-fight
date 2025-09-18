using System;
using GearGame.Control;
using TMPro;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class CombatSpawnerTestController : MonoBehaviour
	{
		[Serializable]
		public class SpawnDetail
		{
			[field: SerializeField]
			public KeyCode Code { get; private set; }

			[field: SerializeField]
			public ScriptableTroop SpawnObject { get; private set; }

			[field: SerializeField]
			public int Level { get; private set; }

			[field: SerializeField]
			public bool IsActive { get; private set; }

			[field: SerializeField]
			public int Num { get; private set; }

			[field: SerializeField]
			public float SpawnIncrementTimer { get; private set; }

			public float LastSpawnTime { get; set; }
		}

		[SerializeField]
		private SpawnDetail[] allySpawnDetails;

		[SerializeField]
		private SpawnDetail[] enemySpawnDetails;

		[SerializeField]
		private TextMeshProUGUI damagePerSecondReadout;

		private double currentDamagePerSecond;

		private float timer;

		private float totalTimer;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Reset()
		{
		}

		private void EnemyHealthChanged(TroopHealthController controller, double hp)
		{
		}

		private void SpawnUpdate(bool isAlly, ref SpawnDetail[] allSpawnDetails)
		{
		}
	}
}
