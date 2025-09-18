using GearGame.Control;
using Items;
using UnityEngine;
using UnityEngine.UI;

namespace GearGame.Gameplay.UI
{
	public class UIMiniGear : MiniGearDisplay
	{
		[SerializeField]
		private Image foregroundImage;

		public ScriptableGear Gear { get; private set; }

		public override void InitializeGear(ScriptableGear gear, TransactionLocation _)
		{
		}
	}
}
