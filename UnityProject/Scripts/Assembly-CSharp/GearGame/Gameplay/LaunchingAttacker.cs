using System.Collections.Generic;
using GearGame.Gameplay.Managers;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class LaunchingAttacker : ProjectileController
	{
		[SerializeField]
		private bool canHitMultipleEnemies;

		[SerializeField]
		private bool zeroOutY;

		[SerializeField]
		private bool doUseMotionCurve;

		[SerializeField]
		private float damageMultiplierPerHit;

		[SerializeField]
		private Transform overrideTransform;

		[SerializeField]
		private bool pinEnemy;

		[SerializeField]
		private float distanceAttack;

		[SerializeField]
		private float hitDistance;

		[SerializeField]
		private bool returnToSender;

		[SerializeField]
		private float returnAcceleration;

		[SerializeField]
		private bool doLimitDistance;

		[SerializeField]
		private float overshootDistance;

		private CharacterManager managerUsed;

		private float returnSpeed;

		private float knockback;

		private bool isReturning;

		private Vector3 returnPosition;

		private Vector2 launchingAttackerTrackingLastPosition;

		private readonly List<TroopController> hitHealthControllers;

		public Transform SendingTransform { get; set; }

		protected override void LateUpdate()
		{
		}

		private void DoDamage(TroopController controller)
		{
		}

		public override void Attack(TroopController controller, CharacterManager manager, float randomWiggleX, float knockBack = 0f)
		{
		}
	}
}
