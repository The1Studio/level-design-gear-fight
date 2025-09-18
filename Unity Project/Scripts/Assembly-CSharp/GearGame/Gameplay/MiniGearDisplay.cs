using GearGame.Control;
using Items;
using UnityEngine;

namespace GearGame.Gameplay
{
	public abstract class MiniGearDisplay : MonoBehaviour
	{
		public abstract void InitializeGear(ScriptableGear gear, TransactionLocation location);

		protected virtual void OnDestroy()
		{
		}
	}
}
