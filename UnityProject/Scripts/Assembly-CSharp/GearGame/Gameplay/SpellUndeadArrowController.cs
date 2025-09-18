namespace GearGame.Gameplay
{
	public class SpellUndeadArrowController : RandomEnemyAttackerPowerup
	{
		protected override IDamageSpellDataProvider GetAttackDataProvider()
		{
			return null;
		}
	}
}
