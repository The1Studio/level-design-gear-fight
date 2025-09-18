using UnityEngine;

namespace GearGame.Gameplay
{
	public class SpellFlamingArrowController : RandomEnemyAttackerPowerup
	{
		[SerializeField]
		private SimpleDOTController flamingDOTController;

		protected override IDamageSpellDataProvider GetAttackDataProvider()
		{
			return null;
		}
	}
}
