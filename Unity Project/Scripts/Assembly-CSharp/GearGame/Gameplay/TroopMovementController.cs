using DG.Tweening;
using GearGame.Gameplay.Misc;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class TroopMovementController : MonoBehaviour
	{
		public enum MovementType
		{
			Walk = 0,
			Hop = 1
		}

		[SerializeField]
		protected MovementType movementType;

		[SerializeField]
		private float jumpHeight;

		[SerializeField]
		protected float jumpDistancePerJump;

		[SerializeField]
		private float delayBeforeJumpForAnimation;

		[SerializeField]
		private float delayPerJump;

		[SerializeField]
		private float jumpDuration;

		[SerializeField]
		private AnimationCurve jumpCurve;

		[SerializeField]
		private bool moveWhileAttacking;

		[SerializeField]
		private bool canBePushedByAllies;

		protected TroopController troopController;

		protected TroopCombatController combatController;

		protected TroopStateController stateController;

		private ShadowProjector shadowProjector;

		private Tween jumpTween;

		private Vector2 targetPosition;

		private float lastYPosition;

		private float delayJump;

		protected float startingY;

		[field: SerializeField]
		public bool CanKnockback { get; set; }

		public float MovementSpeed => 0f;

		public Vector2 YPositionClamp { get; set; }

		public bool Frozen { get; set; }

		public float SpeedMultiplierExternal { get; set; }

		private void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		private void OnValidate()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected void IdleRun()
		{
		}

		protected virtual void RunTowardsTarget(TroopController targetEnemy, float multiplier = 1f)
		{
		}

		protected void TryHopToPosition(Vector2 position, float multiplier = 1f)
		{
		}

		public bool InInDistanceOffset()
		{
			return false;
		}

		private void PushFromAllies()
		{
		}

		private void ResetRotationToDefault()
		{
		}

		protected virtual void LockToBounds()
		{
		}
	}
}
