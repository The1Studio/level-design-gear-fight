using UnityEngine;

namespace GearGame.Gameplay
{
	public interface IGearHolder
	{
		GameObject GameObject { get; }

		float DefaultRotation { get; }

		float ScaleMultiplier { get; }

		bool CanBeUsedInSwaps { get; }

		void RemoveGear(GearController weaponDisplay);

		void AddGear(GearController weaponDisplay);
	}
}
