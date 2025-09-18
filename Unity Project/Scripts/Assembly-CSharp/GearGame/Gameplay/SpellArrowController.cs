namespace GearGame.Gameplay
{
	public class SpellArrowController : RandomEnemyAttackerPowerup
	{
		protected override IDamageSpellDataProvider GetAttackDataProvider()
		{
			return null;
		}
	}
}
