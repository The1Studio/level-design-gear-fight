using System.Collections.Generic;
using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellCannonBallController : MonoBehaviour
	{
		[SerializeField]
		private float halfWidth;

		[SerializeField]
		private float timeBetweenTicks;

		[SerializeField]
		private AudioSourceVariable hitSound;

		[SerializeField]
		private Transform ballTransform;

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

		public void ApplyDamage()
		{
		}
	}
}
