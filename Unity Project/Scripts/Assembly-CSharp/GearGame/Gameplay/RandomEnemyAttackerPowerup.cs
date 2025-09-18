using UnityEngine;

namespace GearGame.Gameplay
{
	public abstract class RandomEnemyAttackerPowerup : MonoBehaviour
	{
		[SerializeField]
		protected ProjectileController associatedProjectile;

		[SerializeField]
		protected float delay;

		protected TroopController targetEnemy;

		protected abstract IDamageSpellDataProvider GetAttackDataProvider();

		protected virtual void Start()
		{
		}

		protected TroopController TryGetCharacter()
		{
			return null;
		}

		protected void TryDoAttack(TroopController targetEnemy, double damageValue, float critMultiplier)
		{
		}
	}
}
