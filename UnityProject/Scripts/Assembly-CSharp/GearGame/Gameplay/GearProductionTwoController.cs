using Gameplay._Data;
using GearGame.Control;

namespace GearGame.Gameplay
{
	public class GearProductionTwoController : GearController
	{
		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		public override GearData GearData => null;

		public override bool CanBeFrozen => false;
	}
}
