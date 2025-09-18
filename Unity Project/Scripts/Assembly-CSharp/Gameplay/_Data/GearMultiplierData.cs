using System;

namespace Gameplay._Data
{
	[Serializable]
	public abstract class GearMultiplierData : GearData
	{
		public abstract float MultiplierValue { get; }
	}
}
