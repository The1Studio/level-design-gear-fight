using Gameplay._Data;
using GearGame.Control;

namespace GearGame.Gameplay
{
	public abstract class MultiplierGearController : GearController
	{
		public abstract GearMultiplierData MultiplierData { get; }

		public override GearData GearData => null;

		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		public override bool CanBeFrozen => false;

		public override int CalculationPrioirtyHigherFirst => 0;

		public override string GetProductionDisplayString()
		{
			return null;
		}

		public override float GetScoreValue(float currentScoreValue)
		{
			return 0f;
		}
	}
}
