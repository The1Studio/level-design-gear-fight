using System;

namespace Gameplay.Blessings
{
	[Serializable]
	public class BlessingsData
	{
		public BlessingData[] Blessings;

		public BlessingData GetBlessingData(BlessingType blessingType)
		{
			return null;
		}

		public bool HasInactiveBlessings()
		{
			return false;
		}
	}
}
