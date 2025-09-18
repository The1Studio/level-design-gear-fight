namespace GearGame.Gameplay
{
	public class SpellPotteryController : RandomEnemyAttackerPowerup
	{
		protected override IDamageSpellDataProvider GetAttackDataProvider()
		{
			return null;
		}
	}
}
