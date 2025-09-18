using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace GearGame.Gameplay
{
	public class TroopCombatController : MonoBehaviour
	{
		public UnityEvent OnAttackCompleted;

		public UnityEvent OnAttackBasic;

		public UnityEvent OnAttackCritical;

		[SerializeField]
		private bool isRanged;

		[SerializeField]
		private int numberShotsPer;

		[SerializeField]
		private bool splitProjectiles;

		[SerializeField]
		private GameObject[] projectilePrefabs;

		[SerializeField]
		private GameObject[] projectilePrefabsEnemy;

		[SerializeField]
		private bool randomProjectile;

		[SerializeField]
		private bool randomTarget;

		[SerializeField]
		private float randomWiggleX;

		[SerializeField]
		private Transform projectileSpawnTransform;

		private readonly int hashTriggerAttack;

		private float attackTimer;

		private int projectileIndex;

		private int maxCleaveNumber;

		private float cleaveRange;

		private float critChance01;

		private float attackDistance;

		private int numberRangedAttacks;

		private TroopController characterController;

		private TroopAnimationController characterAnimationController;

		private TroopStateController characterStateController;

		public double DamagePerAttack { get; set; }

		public bool IsPositionClamped { get; set; }

		public float CritChance01 => 0f;

		public float Knockback { get; set; }

		public event Action<TroopController> OnCharacterAttacked
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

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnValidate()
		{
		}

		public void ActivateCleave(float range, int maxNum)
		{
		}

		public void SetCritChance01(float critChance)
		{
		}

		public void SetDamage(double value)
		{
		}

		public void ScaleDamage(double multiplier)
		{
		}

		public bool IsInAttackRange()
		{
			return false;
		}

		public void OnAttack()
		{
		}

		public static void ApplyAttack(TroopController targetCharacter, double positiveDamage, bool doCleave, int maxCleaveNumber, float cleaveRange, float critMultiplier, float knockback, TroopController attackingMeleeCharacter, bool onlyKnockbackEnemiesTowardsTheirSide = false, Vector2? positionUsed = null)
		{
		}
	}
}
