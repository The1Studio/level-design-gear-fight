using System.Collections.Generic;

namespace GearGame.Control
{
	public class DummyGearUpgradeDataProvider : IGearUpgradeDataProvider
	{
		public Dictionary<GearUpgradeUnlockProfile.Tier, GearUpgradeUnlockProfile.UpgradeDetails> AllUpgradeDetails => null;
	}
}
