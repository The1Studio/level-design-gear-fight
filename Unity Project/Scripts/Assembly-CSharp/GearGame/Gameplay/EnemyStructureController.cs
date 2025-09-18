using System;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class EnemyStructureController : MonoBehaviour
	{
		[SerializeField]
		protected Transform spawnTransform;

		[SerializeField]
		private TroopHealthController healthController;

		[SerializeField]
		private float spawnOffsetX;

		[SerializeField]
		private float originOffsetForDamage;

		private EnemyManager enemyManager;

		private AllyManager allyManager;

		private Action _onAfterKillAnimationCallback;

		public Transform SpawnTransform => null;

		public TroopHealthController HealthController => null;

		public float SpawnOffsetX => 0f;

		public float OriginOffsetForDamage => 0f;

		public bool DamageWhenNoAllies { get; set; }

		public bool DropChest { get; set; }

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		public void Heal()
		{
		}

		protected virtual void OnKilled(TroopHealthController obj)
		{
		}

		public virtual void SetCallbackToOnAfterKillAnimation(Action callback)
		{
		}
	}
}
