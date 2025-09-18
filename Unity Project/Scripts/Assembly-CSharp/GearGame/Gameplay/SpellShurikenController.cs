namespace GearGame.Gameplay
{
	public class SpellShurikenController : RandomEnemyAttackerPowerup
	{
		protected override IDamageSpellDataProvider GetAttackDataProvider()
		{
			return null;
		}
	}
}
