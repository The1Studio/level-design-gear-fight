namespace GearGame.Gameplay
{
	public class SpellVolcanoController : RandomEnemyAttackerPowerup
	{
		protected override IDamageSpellDataProvider GetAttackDataProvider()
		{
			return null;
		}
	}
}
