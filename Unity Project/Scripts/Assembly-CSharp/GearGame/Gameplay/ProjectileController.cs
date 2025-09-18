using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using GearGame.Gameplay.Managers;
using UnityEngine;
using UnityEngine.Events;

namespace GearGame.Gameplay
{
	public class ProjectileController : MonoBehaviour
	{
		public enum FaceForwardDirection
		{
			Right = 0,
			Up = 1
		}

		public enum MovementType
		{
			Jump = 0,
			Move = 1
		}

		public UnityEvent OnProjectileHit;

		[SerializeField]
		protected AnimationCurve motionCurve;

		[SerializeField]
		private AudioSourceVariable impactSource;

		[SerializeField]
		private AudioSourceVariable launchSource;

		[SerializeField]
		protected MovementType thisMovementType;

		[SerializeField]
		protected float jumpHeight;

		[SerializeField]
		private float additionalYOffsetFromEnemy;

		[SerializeField]
		protected bool speedBasedMotion;

		[SerializeField]
		protected float tweenMotionTime;

		[SerializeField]
		private bool faceForwardOnPath;

		[SerializeField]
		private bool destroyOnEnemyHit;

		[SerializeField]
		private GameObject[] objectsToEnableOnHit;

		[SerializeField]
		private GameObject[] deparentOnEnemyHit;

		[SerializeField]
		private GameObject[] objectsToSpawnAndTryApplyToHitEnemy;

		[SerializeField]
		private FaceForwardDirection faceForwardDirection;

		[SerializeField]
		private bool isAOE;

		[SerializeField]
		private float aoeRange;

		[SerializeField]
		private GameObject aoePrefab;

		[SerializeField]
		private bool splitDamage;

		[SerializeField]
		private float totalDamageMultiplierIfSplit;

		[SerializeField]
		private bool doKnockback;

		[SerializeField]
		private float knockBack;

		[SerializeField]
		private bool onlyKnockbackEnemiesTowardsTheirSide;

		private bool isMoving;

		protected double damage;

		private float critMultiplier;

		private Vector3 lastPosition;

		public event Action<SimpleDOTController> OnDOTSpawned
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

		protected virtual void Start()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public virtual void Attack(TroopController controller, CharacterManager manager, float randomWiggleX, float knockBackOverride = -1f)
		{
		}

		protected virtual void ExecuteAttack(TroopController targetEnemy, CharacterManager manager)
		{
		}

		private void TrySpawnOnHitEffects(TroopController character)
		{
		}

		public Tween GetMotion(Transform t, Vector2 finalPosition, float randomWiggleX)
		{
			return null;
		}

		public void SetDamage(double damage, float critMultiplier)
		{
		}

		protected void OnDestroy()
		{
		}
	}
}
