using System;

namespace Gameplay._Data
{
	[Serializable]
	public abstract class GunData : GearSpawnerData
	{
		public abstract int ShotsPerMagazine { get; }

		public abstract int BulletsPerShot { get; }

		public abstract float ShotAngleRandomness { get; }

		public abstract float StartingDelay { get; }

		public abstract float DelayBetweenShots { get; }
	}
}
