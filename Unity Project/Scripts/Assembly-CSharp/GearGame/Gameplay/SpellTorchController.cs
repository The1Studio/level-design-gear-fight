namespace GearGame.Gameplay
{
	public class SpellTorchController : RandomEnemyAttackerPowerup
	{
		protected override IDamageSpellDataProvider GetAttackDataProvider()
		{
			return null;
		}

		private void DOTSpawned(SimpleDOTController dot)
		{
		}
	}
}
