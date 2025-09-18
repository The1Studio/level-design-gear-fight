using UnityEngine;

namespace GearGame.Gameplay
{
	public class GroundAOEEffect : MonoBehaviour
	{
		[SerializeField]
		private bool doesTick;

		[SerializeField]
		private float halfWidth;

		[SerializeField]
		private bool knockback;

		[SerializeField]
		private bool hitEnemies;

		[SerializeField]
		private AudioSourceVariable impactSource;

		[SerializeField]
		private float knockbackAmount;

		[SerializeField]
		private float timeBetweenTicks;

		[SerializeField]
		private bool doMultiplyDamageByTimeBetweenTicks;

		[SerializeField]
		private float aliveTimer;

		private float tickTimer;

		private float timer;

		private float critMultiplier;

		private double damage;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}

		public void SetDamageInformation(double damage, float knockback, float critMultiplier)
		{
		}

		public void ApplyBaseDamage()
		{
		}

		public void ApplyDamage(double amount)
		{
		}
	}
}
