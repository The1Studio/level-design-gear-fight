using System.Collections.Generic;

namespace GearGame.Control
{
	public interface IGearUpgradeDataProvider
	{
		private static IGearUpgradeDataProvider instance;

		static IGearUpgradeDataProvider Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		Dictionary<GearUpgradeUnlockProfile.Tier, GearUpgradeUnlockProfile.UpgradeDetails> AllUpgradeDetails { get; }
	}
}
