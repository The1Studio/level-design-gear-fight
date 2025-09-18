using GearGame.Control;

namespace GearGame.Gameplay
{
	public interface ISpellAttackDataProvider : ISpellDataProvider
	{
		static double GetDummyDamage(ScriptableGear gear)
		{
			return 0.0;
		}

		static float EvaluateAndReturnCritMultiplier(float critChance, float critMultiplier)
		{
			return 0f;
		}

		static float GetDummyTierMultiplier(ScriptableGear gear)
		{
			return 0f;
		}
	}
}
