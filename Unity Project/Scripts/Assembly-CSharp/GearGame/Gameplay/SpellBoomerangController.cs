namespace GearGame.Gameplay
{
	public class SpellBoomerangController : RandomEnemyAttackerPowerup
	{
		protected override IDamageSpellDataProvider GetAttackDataProvider()
		{
			return null;
		}
	}
}
