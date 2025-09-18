using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public abstract class GearSpinnerController : GearController
	{
		[SerializeField]
		private float accelerationRatePerSecond;

		[SerializeField]
		private float slowdownPerHit;

		[SerializeField]
		private float maxSlowdownEffectPercentOfMaxSpeed;

		[SerializeField]
		private float upRotationValue;

		[SerializeField]
		private float rightRotationValue;

		[SerializeField]
		private float downRotationValue;

		[SerializeField]
		private float leftRotationValue;

		[SerializeField]
		private float rotationSpeedPerSecond;

		[SerializeField]
		private float rotationSpeedPerSecondMin;

		[SerializeField]
		private float timeUntilFullSlowdownReached;

		[SerializeField]
		private float timeUntilFullSlowdownReachedDelay;

		[SerializeField]
		private ParticleSystem[] allFullPowerSystems;

		[SerializeField]
		private AudioSource electroSource;

		[SerializeField]
		private AudioSource powerUpSource;

		private float currentRotationSpeed;

		private double additionalRotationSpeed;

		private float fullPowerLerpValue;

		private bool fullPowerActive;

		private float fullPowerTimer;

		private float rotationSpeedSlowdownTimer;

		private float netRotationSlowdown;

		private float fullPowerMultiplier;

		public override bool RotateWithNeighbors => false;

		public float RotationSpeedPerSecond => 0f;

		public float AccelerationPerSecond => 0f;

		protected override bool JumpToTargetRotationOnPlacement => false;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private new void StateChanged(GameStateManager.GameState _)
		{
		}

		protected override void Update()
		{
		}

		public void TriggerFullPower(float duration, float multiplier)
		{
		}

		protected override void UpdateRotation()
		{
		}

		private void OnGearHit()
		{
		}
	}
}
