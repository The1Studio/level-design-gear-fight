namespace GearGame.Gameplay
{
	public interface IDamageSpellDataProvider
	{
		double Damage { get; }

		float CritChance { get; }

		float CritMultiplier { get; }
	}
}
