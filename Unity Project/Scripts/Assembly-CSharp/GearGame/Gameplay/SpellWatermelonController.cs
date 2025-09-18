namespace GearGame.Gameplay
{
	public class SpellWatermelonController : RandomEnemyAttackerPowerup
	{
		protected override IDamageSpellDataProvider GetAttackDataProvider()
		{
			return null;
		}
	}
}
