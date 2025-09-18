namespace GearGame.Gameplay
{
	public class SpellUndeadEyeController : RandomEnemyAttackerPowerup
	{
		protected override IDamageSpellDataProvider GetAttackDataProvider()
		{
			return null;
		}
	}
}
