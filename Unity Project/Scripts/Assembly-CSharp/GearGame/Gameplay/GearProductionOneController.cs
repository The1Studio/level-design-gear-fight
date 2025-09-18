using Gameplay._Data;
using GearGame.Control;

namespace GearGame.Gameplay
{
	public class GearProductionOneController : GearController
	{
		public override GearData GearData => null;

		public override ScriptableGear.GearType GearType => default(ScriptableGear.GearType);

		public override bool CanBeFrozen => false;
	}
}
