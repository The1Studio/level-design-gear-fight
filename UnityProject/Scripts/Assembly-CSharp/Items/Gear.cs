using GearGame.Control;

namespace Items
{
	public class Gear : Item
	{
		public ScriptableGear GearSettings { get; private set; }

		public override ItemSO Settings => null;

		public Gear(ScriptableGear gearSettings)
		{
		}
	}
}
