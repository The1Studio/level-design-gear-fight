using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellKunaiController : RandomEnemyAttackerPowerup
	{
		[SerializeField]
		private Vector3 startingDirection;

		private bool didStart;

		private void LateUpdate()
		{
		}

		protected override IDamageSpellDataProvider GetAttackDataProvider()
		{
			return null;
		}

		protected override void Start()
		{
		}
	}
}
