using System.Collections.Generic;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class ForestGolemRollingStoneAttack : MonoBehaviour
	{
		[SerializeField]
		private float halfWidth;

		[SerializeField]
		private float knockbackAmount;

		[SerializeField]
		private float timeBetweenTicks;

		[SerializeField]
		private AudioSourceVariable hitSound;

		[SerializeField]
		private Transform ballTransform;

		private double damagePerHit;

		private float tickTimer;

		private readonly List<TroopController> enemyControllers;

		private void Update()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		public void ApplyBaseDamage()
		{
		}

		public void OnAnimationCompleted()
		{
		}

		public void ApplyDamage(double amount)
		{
		}

		public void SetDamage(double damagePerAttack)
		{
		}
	}
}
