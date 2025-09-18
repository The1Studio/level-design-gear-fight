using UnityEngine;

namespace GearGame.UI
{
	public class CustomGearsBottomTrayController : MonoBehaviour
	{
		[SerializeField]
		private CustomEquippedGearSlotDisplayController[] allGearSelections;

		private GearEquippingCanvas gearCanvas;

		private float _lastClickTime;

		private void Start()
		{
		}

		public void ActivateSwap(GearEquippingCanvas canvas)
		{
		}

		internal void DeactivateSwap()
		{
		}

		private void ItemClicked(CustomEquippedGearSlotDisplayController gear)
		{
		}
	}
}
